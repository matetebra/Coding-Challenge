using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodingChallenge
{
    public partial class Form1 : Form
    {
        TennisPlayer tp1 = new TennisPlayer(Properties.Resources.djokovic, 1, "SRB", "Novak Djokovic", 0);
        TennisPlayer tp2 = new TennisPlayer(Properties.Resources.medvedev, 2, "RUS", "Daniil Medvedev", 0);
        TennisPlayer tp3 = new TennisPlayer(Properties.Resources.zverev, 3, "GER", "Alexander Zverev", 0);
        TennisPlayer tp4 = new TennisPlayer(Properties.Resources.nadal, 4, "ESP", "Rafael Nadal", 0);
        TennisPlayer tp5 = new TennisPlayer(Properties.Resources.tsitsipas, 5, "GRE", "Stefanos Tsitsipas", 0);
        TennisPlayer tp6 = new TennisPlayer(Properties.Resources.berrettini, 6, "ITA", "Matteo Berrettini", 0);
        TennisPlayer tp7 = new TennisPlayer(Properties.Resources.ruud, 7, "NOR", "Casper Ruud", 0);
        TennisPlayer tp8 = new TennisPlayer(Properties.Resources.rublev, 8, "RUS", "Andrey Rublev", 0);
        List<TennisPlayer> listOfPlayers = new List<TennisPlayer>();
        Random rnd = new Random();
        int round;       // proveravacemo da li se igra cetvrtfinale, polufinale ili finale da bi znali gde da upisemo game-ove i setove
        public Form1()
        {         
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AddPlayers();
            for (int i = 0; i < listOfPlayers.Count(); i++)
            {
                ListViewItem list = new ListViewItem(new string[] { listOfPlayers[i].Rank.ToString(), listOfPlayers[i].State.ToString(), listOfPlayers[i].NameAndSurname, listOfPlayers[i].Pts.ToString(), });
                listView1.Items.Add(list); // upisujemo igrace u listu za prikaz
            }
        }

        private void AddPlayers()
        {
            listOfPlayers.Add(tp1);
            listOfPlayers.Add(tp2);
            listOfPlayers.Add(tp3);
            listOfPlayers.Add(tp4);
            listOfPlayers.Add(tp5);
            listOfPlayers.Add(tp6);
            listOfPlayers.Add(tp7);
            listOfPlayers.Add(tp8);
        }

        private void start_Click(object sender, EventArgs e)
        {
            listOfPlayers.Clear();  // brisemo listu i ponovo dodajemo iste igrace kao na pocetku za ponovno random generisanje turnira pritiskom na dugme start
            AddPlayers();           // sto znaci da nema potrebe da se gasi program i ponovo pokrece, vec moze odmah vise puta da se klikce na dugme
            foreach (TennisPlayer tp in listOfPlayers)
            {
                tp.Pts = 0;     // stavljamo svim igracima poene na 0
            }
            createSkeletons();
        }

        private void createSkeletons()
        {
            List<TennisPlayer> leftSkeleton = new List<TennisPlayer>();
            List<TennisPlayer> rightSkeleton = new List<TennisPlayer>();
            leftSkeleton.Add(tp1);
            leftSkeletonQuarter1.Text = tp1.NameAndSurname;
            rightSkeleton.Add(tp2); // odvajamo prva dva igraca sa liste (prvi u levi skeleton, drugi u desni)
            rightSkeletonQuarter1.Text = tp2.NameAndSurname;
            int[] usedNumbers = new int[6];  // u ovaj niz smestamo random generisane brojeve
            bool addInLeftSkeleton = false;  // pomocu ovoga cemo odredjivati da li smestamo u levi ili desni skeleton (jednom u desni, jednom u levi i tako dok ne upisemo sve igrace)
            for (int i = 0; i < listOfPlayers.Count()-2; i++)   // -2 jer nam ostaju jos 6 igraca za rasporedjivanje
            {
                int randomNumber = rnd.Next(3, 9);  // obzirom da smo prva dva igraca smestili u levi i desni skeleton ostatak igraca smestamo nasumicno (pozicije od 3 do 8)
                while (usedNumbers.Contains(randomNumber))
                {
                    randomNumber = rnd.Next(3, 9);  // generisemo random broj od 3 do 8 sve dok ne dodjemo do broja koji nije iskoriscen
                }
                usedNumbers[i] = randomNumber;  // upisujemo taj broj kako se ne bi ponovio

                if (addInLeftSkeleton == true)
                {
                    leftSkeleton.Add(listOfPlayers[randomNumber - 1]);  // imamo randomNumber-1 jer u listi se pocinje od 0 i svaki igrac je pomeren za jednu poziciju ulevo
                    addInLeftSkeleton = false;  // postavljamo na false da bi se u sledecem krugu smestio igrac u desni skeleton                  
                }
                else
                {
                    rightSkeleton.Add(listOfPlayers[randomNumber - 1]);
                    addInLeftSkeleton = true;
                }
            }

            #region Visibility for quarter

            leftSkeletonQuarter2.Text = leftSkeleton[1].NameAndSurname;
            leftSkeletonQuarter3.Text = leftSkeleton[2].NameAndSurname;     // upisujemo nazive igraca za levi skeleton
            leftSkeletonQuarter4.Text = leftSkeleton[3].NameAndSurname;

            leftSkeletonQuarter1.Visible = true;
            leftSkeletonQuarter2.Visible = true;
            leftSkeletonQuarter3.Visible = true;
            leftSkeletonQuarter4.Visible = true;

            rightSkeletonQuarter2.Text = rightSkeleton[1].NameAndSurname;
            rightSkeletonQuarter3.Text = rightSkeleton[2].NameAndSurname;   // upisujemo nazive igraca za desni skeleton
            rightSkeletonQuarter4.Text = rightSkeleton[3].NameAndSurname;

            rightSkeletonQuarter1.Visible = true;
            rightSkeletonQuarter2.Visible = true;
            rightSkeletonQuarter3.Visible = true;
            rightSkeletonQuarter4.Visible = true;

            #endregion


            List<TennisPlayer> newListQuarter = new List<TennisPlayer>();
            bool switchSkeletons = false;
            for (int i = 0; i < 4; i++)
            {
                if (switchSkeletons == false)
                {
                    newListQuarter.Add(leftSkeleton[i]);   // smestamo igrace iz levog skeletona na pozicije od 0 do 3
                    if (i == 3)
                    {
                        i = -1;     // -1 a ne 0 jer kad ponovo vrati u for petlju prvo inkrementira (bilo bi i = 1 umesto i = 0 i preskocio bi prvog igraca iz desnog skeletona)
                        switchSkeletons = true;
                    }
                }                     
                else
                    newListQuarter.Add(rightSkeleton[i]);    // smestamo igrace iz desnog skeletona na pozicije od 4 do 7
            }

            round = 1;  //  prva runda predstavlja cetvrtfinale
            List<TennisPlayer> newListSemi = PlayGame(newListQuarter);
            foreach (TennisPlayer tp in newListSemi)
            {
                tp.Pts += 2;    //  recimo da igraci koji su prosli cetvrtfinale dobijaju po 2 poena
            }
            
            #region Visibility for semi

            leftSkeletonSemi1.Text = newListSemi[0].NameAndSurname;
            leftSkeletonSemi2.Text = newListSemi[1].NameAndSurname;

            leftSkeletonSemi1.Visible = true;
            leftSkeletonSemi2.Visible = true;

            rightSkeletonSemi1.Text = newListSemi[2].NameAndSurname;
            rightSkeletonSemi2.Text = newListSemi[3].NameAndSurname;

            rightSkeletonSemi1.Visible = true;
            rightSkeletonSemi2.Visible = true;

            #endregion

            round = 2;  //  druga runda predstavlja polufinale
            List<TennisPlayer> newListFinal = PlayGame(newListSemi);
            foreach (TennisPlayer tp in newListFinal)
            {
                tp.Pts += 4;    // igraci koji su prosli polufinale dobijaju jos 4 po poena
            }

            #region Visibility for final

            leftSkeletonFinal.Text = newListFinal[0].NameAndSurname;

            leftSkeletonFinal.Visible = true;

            rightSkeletonFinal.Text = newListFinal[1].NameAndSurname;

            rightSkeletonFinal.Visible = true;

            #endregion

            round = 3;  // treca runda je finale
            List<TennisPlayer> winner = PlayGame(newListFinal);
            winner[0].Pts += 6; //  igrac koji je osvojio turnir dobija jos 6 poena

            winnerName.Text = winner[0].NameAndSurname; //  ispisujemo naziv igraca
            winnerName.Visible = true;
            winnerOfTheTour.Visible = true;
            pictureBox1.BackgroundImage = winner[0].Picture;    //  prikazujemo njegovu sliku

            //  bubble sort
            //  sortiramo igrace po broju poena

            for (int i = 0; i < listOfPlayers.Count() - 1; i++)
                for (int j = 0; j < listOfPlayers.Count() - i - 1; j++)
                    if (listOfPlayers[j].Pts < listOfPlayers[j + 1].Pts)
                    {
                        TennisPlayer tmp = listOfPlayers[j];
                        listOfPlayers[j] = listOfPlayers[j + 1];
                        listOfPlayers[j + 1] = tmp;
                    }

            listView1.Items.Clear();        // brisemo prethodnu listu da bi upisali novu
            int rankNumber = 1;
            for (int i = 0; i < listOfPlayers.Count(); i++)
            {
                listOfPlayers[i].Rank = rankNumber;     // upisujemo nove rankove igracima
                ListViewItem list = new ListViewItem(new string[] { listOfPlayers[i].Rank.ToString(), listOfPlayers[i].State.ToString(), listOfPlayers[i].NameAndSurname, listOfPlayers[i].Pts.ToString(), });
                listView1.Items.Add(list);
                rankNumber++;
            }

        }

        private List<TennisPlayer> PlayGame(List<TennisPlayer> list)
        {
            List<TennisPlayer> listToReturn = new List<TennisPlayer>();

            for (int i = 0; i < list.Count(); i += 2)
            {
                int setLeftPlayerForResult, setRightPlayerForResult;    // setovi koji se prikazuju
                int game1LeftPlayerForResult = 0, game2LeftPlayerForResult = 0, game3LeftPlayerForResult = 0;   // odigrani game-ovi za setove koji se prikazuju (levi igraca)
                int game1RightPlayerForResult = 0, game2RightPlayerForResult = 0, game3RightPlayerForResult = 0;    // odigrani game-ovi za setove koji se prikazuju (desni igrac)
                int setLeftPlayer = 0, setRightPlayer = 0;
                while (setLeftPlayer < 2 && setRightPlayer < 2)
                {
                    int gameLeftPlayer = 0, gameRightPlayer = 0;              
                    while ((gameLeftPlayer < 6 || gameLeftPlayer - gameRightPlayer <= 1) && (gameRightPlayer < 6 || gameRightPlayer - gameLeftPlayer <= 1))
                    {

                        if (list[i].Rank < list[i + 1].Rank)
                        {
                            if (list[i + 1].Rank - list[i].Rank >= 3)     // ako je igrac sa boljim rankom bolji za 3 ili vise ranka od igraca sa losijim rankom
                            {
                                int randomNumber = rnd.Next(1, 4);      // generisemo random broj od 1 do 3
                                if (randomNumber == 1 || randomNumber == 3)     // sanse su 66.66% prema 33.33% da ce bolji igrac da dobije game
                                    gameLeftPlayer++;       // 1 ili 3 za igraca sa boljim rankom
                                else
                                    gameRightPlayer++;      // 2 za igraca sa losijim rankom
                            }
                            else if (list[i + 1].Rank - list[i].Rank < 3)      // ako je igrac sa boljim Rankom za manje od 3 ranka ispred igraca sa losijim rankom
                            {
                                int randomNumber = rnd.Next(1, 6);      // generisemo random broj od 1 do 5
                                if (randomNumber == 1 || randomNumber == 3 || randomNumber == 5)    // sanse su 60% prema 40% da ce bolji igrac da dobije game
                                    gameLeftPlayer++;       // 1, 3 ili 5 za igraca sa boljim rankom
                                else
                                    gameRightPlayer++;      // 2 ili 4 za igraca sa losijim rankom
                            }
                        }
                        else
                        {
                            if (list[i].Rank - list[i + 1].Rank >= 3)     // sve isto samo u ovom slucaju desni igrac ima bolji rank od levog 
                            {
                                int randomNumber = rnd.Next(1, 4);
                                if (randomNumber == 1 || randomNumber == 3)
                                    gameRightPlayer++;
                                else
                                    gameLeftPlayer++;
                            }
                            else if (list[i].Rank - list[i + 1].Rank < 3)
                            {
                                int randomNumber = rnd.Next(1, 6);
                                if (randomNumber == 1 || randomNumber == 3 || randomNumber == 5)
                                    gameRightPlayer++;
                                else
                                    gameLeftPlayer++;
                            }
                        }
                    }

                    if (setLeftPlayer == 0 && setRightPlayer == 0)  //  prvi set upisuju se game-ovi za taj set
                    {
                        game1LeftPlayerForResult = gameLeftPlayer;
                        game1RightPlayerForResult = gameRightPlayer;
                    }
                    if ((setLeftPlayer == 1 && setRightPlayer == 0) || (setLeftPlayer == 0 && setRightPlayer == 1)) //  drugi set upisuju se game-ovi za taj set
                    {
                        game2LeftPlayerForResult = gameLeftPlayer;
                        game2RightPlayerForResult = gameRightPlayer;
                    }
                    if (setLeftPlayer == 1 && setRightPlayer == 1)  //  igra se u 2 dobijena seta, ukoliko bude 1-1 igra se i taj treci set i upisuju game-ovi za njega
                    {
                        game3LeftPlayerForResult = gameLeftPlayer;
                        game3RightPlayerForResult = gameRightPlayer;
                    }
                    
                    if (gameLeftPlayer > gameRightPlayer)   // proveravamo ko je dobio taj set
                        setLeftPlayer++;
                    else
                        setRightPlayer++;
                }

                #region Visibility for games and sets

                setLeftPlayerForResult = setLeftPlayer;
                setRightPlayerForResult = setRightPlayer;

                if (round == 1) //  cetvrtfinale
                {
                    if (i == 0) // ukoliko prva dva gornja igraca iz levog skeletona igraju upisujemo game-ove i setove za njih
                    {
                        LG1Q1.Text = game1LeftPlayerForResult.ToString();
                        LG2Q1.Text = game2LeftPlayerForResult.ToString();
                        LG3Q1.Text = game3LeftPlayerForResult.ToString();

                        LG1Q2.Text = game1RightPlayerForResult.ToString();
                        LG2Q2.Text = game2RightPlayerForResult.ToString();
                        LG3Q2.Text = game3RightPlayerForResult.ToString();

                        LSQ1.Text = setLeftPlayerForResult.ToString();
                        LSQ2.Text = setRightPlayerForResult.ToString();
                    }
                    if (i == 2) //  druga dva donja igraca iz levog skeletona game-ovi i setovi za njih
                    {
                        LG1Q3.Text = game1LeftPlayerForResult.ToString();
                        LG2Q3.Text = game2LeftPlayerForResult.ToString();
                        LG3Q3.Text = game3LeftPlayerForResult.ToString();

                        LG1Q4.Text = game1RightPlayerForResult.ToString();
                        LG2Q4.Text = game2RightPlayerForResult.ToString();
                        LG3Q4.Text = game3RightPlayerForResult.ToString();

                        LSQ3.Text = setLeftPlayerForResult.ToString();
                        LSQ4.Text = setRightPlayerForResult.ToString();
                    }
                    if (i == 4) // game-ovi i setovi za igrace iz gornjeg desnog skeletona
                    {
                        RG1Q1.Text = game1LeftPlayerForResult.ToString();
                        RG2Q1.Text = game2LeftPlayerForResult.ToString();
                        RG3Q1.Text = game3LeftPlayerForResult.ToString();

                        RG1Q2.Text = game1RightPlayerForResult.ToString();
                        RG2Q2.Text = game2RightPlayerForResult.ToString();
                        RG3Q2.Text = game3RightPlayerForResult.ToString();

                        RSQ1.Text = setLeftPlayerForResult.ToString();
                        RSQ2.Text = setRightPlayerForResult.ToString();
                    }
                    if (i == 6) // game-ovi i setovi za igrace iz donjeg desnog skeletona
                    {
                        RG1Q3.Text = game1LeftPlayerForResult.ToString();
                        RG2Q3.Text = game2LeftPlayerForResult.ToString();
                        RG3Q3.Text = game3LeftPlayerForResult.ToString();

                        RG1Q4.Text = game1RightPlayerForResult.ToString();
                        RG2Q4.Text = game2RightPlayerForResult.ToString();
                        RG3Q4.Text = game3RightPlayerForResult.ToString();

                        RSQ3.Text = setLeftPlayerForResult.ToString();
                        RSQ4.Text = setRightPlayerForResult.ToString();
                    }
                }

                if (round == 2) // polufinale
                {
                    if (i == 0) // game-ovi i setovi za polufinale levog skeletona
                    {
                        LG1S1.Text = game1LeftPlayerForResult.ToString();
                        LG2S1.Text = game2LeftPlayerForResult.ToString();
                        LG3S1.Text = game3LeftPlayerForResult.ToString();

                        LG1S2.Text = game1RightPlayerForResult.ToString();
                        LG2S2.Text = game2RightPlayerForResult.ToString();
                        LG3S2.Text = game3RightPlayerForResult.ToString();

                        LSS1.Text = setLeftPlayerForResult.ToString();
                        LSS2.Text = setRightPlayerForResult.ToString();
                    }
                    if (i == 2) // game-ovi i setovi za polufinale desnog skeletona
                    {
                        RG1S1.Text = game1LeftPlayerForResult.ToString();
                        RG2S1.Text = game2LeftPlayerForResult.ToString();
                        RG3S1.Text = game3LeftPlayerForResult.ToString();

                        RG1S2.Text = game1RightPlayerForResult.ToString();
                        RG2S2.Text = game2RightPlayerForResult.ToString();
                        RG3S2.Text = game3RightPlayerForResult.ToString();

                        RSS1.Text = setLeftPlayerForResult.ToString();
                        RSS2.Text = setRightPlayerForResult.ToString();
                    }
                }
                
                if (round == 3) // finale
                {
                    LG1F1.Text = game1LeftPlayerForResult.ToString();
                    LG2F1.Text = game2LeftPlayerForResult.ToString();
                    LG3F1.Text = game3LeftPlayerForResult.ToString();

                    RG1F1.Text = game1RightPlayerForResult.ToString();
                    RG2F1.Text = game2RightPlayerForResult.ToString();
                    RG3F1.Text = game3RightPlayerForResult.ToString();

                    LSF1.Text = setLeftPlayerForResult.ToString();
                    RSF1.Text = setRightPlayerForResult.ToString();
                }

                #endregion

                if (setLeftPlayer == 2)
                    listToReturn.Add(list[i]);     // levi igrac je pobedio
                else
                    listToReturn.Add(list[i + 1]);     // desni igrac je pobedio
            }

            return listToReturn;
        }
    }
}
