
namespace CodingChallenge
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView1 = new System.Windows.Forms.ListView();
            this.ranking = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.state = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.player = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.points = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.start = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.winnerName = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.leftSkeletonQuarter1 = new System.Windows.Forms.Label();
            this.leftSkeletonQuarter2 = new System.Windows.Forms.Label();
            this.leftSkeletonQuarter3 = new System.Windows.Forms.Label();
            this.leftSkeletonQuarter4 = new System.Windows.Forms.Label();
            this.rightSkeletonQuarter1 = new System.Windows.Forms.Label();
            this.rightSkeletonQuarter2 = new System.Windows.Forms.Label();
            this.rightSkeletonQuarter3 = new System.Windows.Forms.Label();
            this.rightSkeletonQuarter4 = new System.Windows.Forms.Label();
            this.leftSkeletonSemi1 = new System.Windows.Forms.Label();
            this.leftSkeletonSemi2 = new System.Windows.Forms.Label();
            this.rightSkeletonSemi1 = new System.Windows.Forms.Label();
            this.rightSkeletonSemi2 = new System.Windows.Forms.Label();
            this.leftSkeletonFinal = new System.Windows.Forms.Label();
            this.rightSkeletonFinal = new System.Windows.Forms.Label();
            this.winnerOfTheTour = new System.Windows.Forms.Label();
            this.LSQ1 = new System.Windows.Forms.Label();
            this.LG1Q1 = new System.Windows.Forms.Label();
            this.LG2Q1 = new System.Windows.Forms.Label();
            this.LG3Q1 = new System.Windows.Forms.Label();
            this.LG3Q2 = new System.Windows.Forms.Label();
            this.LG2Q2 = new System.Windows.Forms.Label();
            this.LG1Q2 = new System.Windows.Forms.Label();
            this.LSQ2 = new System.Windows.Forms.Label();
            this.LG3Q3 = new System.Windows.Forms.Label();
            this.LG2Q3 = new System.Windows.Forms.Label();
            this.LG1Q3 = new System.Windows.Forms.Label();
            this.LSQ3 = new System.Windows.Forms.Label();
            this.LG3Q4 = new System.Windows.Forms.Label();
            this.LG2Q4 = new System.Windows.Forms.Label();
            this.LG1Q4 = new System.Windows.Forms.Label();
            this.LSQ4 = new System.Windows.Forms.Label();
            this.LG3S1 = new System.Windows.Forms.Label();
            this.LG2S1 = new System.Windows.Forms.Label();
            this.LG1S1 = new System.Windows.Forms.Label();
            this.LSS1 = new System.Windows.Forms.Label();
            this.LG3S2 = new System.Windows.Forms.Label();
            this.LG2S2 = new System.Windows.Forms.Label();
            this.LG1S2 = new System.Windows.Forms.Label();
            this.LSS2 = new System.Windows.Forms.Label();
            this.RG3Q1 = new System.Windows.Forms.Label();
            this.RG2Q1 = new System.Windows.Forms.Label();
            this.RG1Q1 = new System.Windows.Forms.Label();
            this.RSQ1 = new System.Windows.Forms.Label();
            this.RG3Q2 = new System.Windows.Forms.Label();
            this.RG2Q2 = new System.Windows.Forms.Label();
            this.RG1Q2 = new System.Windows.Forms.Label();
            this.RSQ2 = new System.Windows.Forms.Label();
            this.RG3Q3 = new System.Windows.Forms.Label();
            this.RG2Q3 = new System.Windows.Forms.Label();
            this.RG1Q3 = new System.Windows.Forms.Label();
            this.RSQ3 = new System.Windows.Forms.Label();
            this.RG3Q4 = new System.Windows.Forms.Label();
            this.RG2Q4 = new System.Windows.Forms.Label();
            this.RG1Q4 = new System.Windows.Forms.Label();
            this.RSQ4 = new System.Windows.Forms.Label();
            this.RG3S1 = new System.Windows.Forms.Label();
            this.RG2S1 = new System.Windows.Forms.Label();
            this.RG1S1 = new System.Windows.Forms.Label();
            this.RSS1 = new System.Windows.Forms.Label();
            this.RG3S2 = new System.Windows.Forms.Label();
            this.RG2S2 = new System.Windows.Forms.Label();
            this.RG1S2 = new System.Windows.Forms.Label();
            this.RSS2 = new System.Windows.Forms.Label();
            this.LG3F1 = new System.Windows.Forms.Label();
            this.LG2F1 = new System.Windows.Forms.Label();
            this.LG1F1 = new System.Windows.Forms.Label();
            this.LSF1 = new System.Windows.Forms.Label();
            this.RG3F1 = new System.Windows.Forms.Label();
            this.RG2F1 = new System.Windows.Forms.Label();
            this.RG1F1 = new System.Windows.Forms.Label();
            this.RSF1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ranking,
            this.state,
            this.player,
            this.points});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(239, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(244, 164);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // ranking
            // 
            this.ranking.Text = "Rank";
            this.ranking.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ranking.Width = 46;
            // 
            // state
            // 
            this.state.Text = "State";
            this.state.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.state.Width = 46;
            // 
            // player
            // 
            this.player.Text = "Player";
            this.player.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.player.Width = 99;
            // 
            // points
            // 
            this.points.Text = "Points";
            this.points.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.points.Width = 46;
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(522, 551);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(102, 33);
            this.start.TabIndex = 2;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Location = new System.Drawing.Point(226, 221);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(273, 253);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // winnerName
            // 
            this.winnerName.AutoSize = true;
            this.winnerName.Location = new System.Drawing.Point(332, 486);
            this.winnerName.Name = "winnerName";
            this.winnerName.Size = new System.Drawing.Size(35, 13);
            this.winnerName.TabIndex = 5;
            this.winnerName.Text = "label1";
            this.winnerName.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::CodingChallenge.Properties.Resources.tournament2;
            this.pictureBox3.InitialImage = null;
            this.pictureBox3.Location = new System.Drawing.Point(602, 66);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(550, 267);
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // leftSkeletonQuarter1
            // 
            this.leftSkeletonQuarter1.AutoSize = true;
            this.leftSkeletonQuarter1.Location = new System.Drawing.Point(607, 85);
            this.leftSkeletonQuarter1.Name = "leftSkeletonQuarter1";
            this.leftSkeletonQuarter1.Size = new System.Drawing.Size(35, 13);
            this.leftSkeletonQuarter1.TabIndex = 8;
            this.leftSkeletonQuarter1.Text = "label3";
            this.leftSkeletonQuarter1.Visible = false;
            // 
            // leftSkeletonQuarter2
            // 
            this.leftSkeletonQuarter2.AutoSize = true;
            this.leftSkeletonQuarter2.Location = new System.Drawing.Point(607, 157);
            this.leftSkeletonQuarter2.Name = "leftSkeletonQuarter2";
            this.leftSkeletonQuarter2.Size = new System.Drawing.Size(35, 13);
            this.leftSkeletonQuarter2.TabIndex = 9;
            this.leftSkeletonQuarter2.Text = "label4";
            this.leftSkeletonQuarter2.Visible = false;
            // 
            // leftSkeletonQuarter3
            // 
            this.leftSkeletonQuarter3.AutoSize = true;
            this.leftSkeletonQuarter3.Location = new System.Drawing.Point(607, 228);
            this.leftSkeletonQuarter3.Name = "leftSkeletonQuarter3";
            this.leftSkeletonQuarter3.Size = new System.Drawing.Size(35, 13);
            this.leftSkeletonQuarter3.TabIndex = 10;
            this.leftSkeletonQuarter3.Text = "label5";
            this.leftSkeletonQuarter3.Visible = false;
            // 
            // leftSkeletonQuarter4
            // 
            this.leftSkeletonQuarter4.AutoSize = true;
            this.leftSkeletonQuarter4.Location = new System.Drawing.Point(607, 300);
            this.leftSkeletonQuarter4.Name = "leftSkeletonQuarter4";
            this.leftSkeletonQuarter4.Size = new System.Drawing.Size(35, 13);
            this.leftSkeletonQuarter4.TabIndex = 11;
            this.leftSkeletonQuarter4.Text = "label6";
            this.leftSkeletonQuarter4.Visible = false;
            // 
            // rightSkeletonQuarter1
            // 
            this.rightSkeletonQuarter1.AutoSize = true;
            this.rightSkeletonQuarter1.Location = new System.Drawing.Point(1063, 85);
            this.rightSkeletonQuarter1.Name = "rightSkeletonQuarter1";
            this.rightSkeletonQuarter1.Size = new System.Drawing.Size(35, 13);
            this.rightSkeletonQuarter1.TabIndex = 12;
            this.rightSkeletonQuarter1.Text = "label7";
            this.rightSkeletonQuarter1.Visible = false;
            // 
            // rightSkeletonQuarter2
            // 
            this.rightSkeletonQuarter2.AutoSize = true;
            this.rightSkeletonQuarter2.Location = new System.Drawing.Point(1063, 157);
            this.rightSkeletonQuarter2.Name = "rightSkeletonQuarter2";
            this.rightSkeletonQuarter2.Size = new System.Drawing.Size(35, 13);
            this.rightSkeletonQuarter2.TabIndex = 13;
            this.rightSkeletonQuarter2.Text = "label8";
            this.rightSkeletonQuarter2.Visible = false;
            // 
            // rightSkeletonQuarter3
            // 
            this.rightSkeletonQuarter3.AutoSize = true;
            this.rightSkeletonQuarter3.Location = new System.Drawing.Point(1063, 228);
            this.rightSkeletonQuarter3.Name = "rightSkeletonQuarter3";
            this.rightSkeletonQuarter3.Size = new System.Drawing.Size(35, 13);
            this.rightSkeletonQuarter3.TabIndex = 14;
            this.rightSkeletonQuarter3.Text = "label9";
            this.rightSkeletonQuarter3.Visible = false;
            // 
            // rightSkeletonQuarter4
            // 
            this.rightSkeletonQuarter4.AutoSize = true;
            this.rightSkeletonQuarter4.Location = new System.Drawing.Point(1063, 300);
            this.rightSkeletonQuarter4.Name = "rightSkeletonQuarter4";
            this.rightSkeletonQuarter4.Size = new System.Drawing.Size(41, 13);
            this.rightSkeletonQuarter4.TabIndex = 15;
            this.rightSkeletonQuarter4.Text = "label10";
            this.rightSkeletonQuarter4.Visible = false;
            // 
            // leftSkeletonSemi1
            // 
            this.leftSkeletonSemi1.AutoSize = true;
            this.leftSkeletonSemi1.Location = new System.Drawing.Point(720, 121);
            this.leftSkeletonSemi1.Name = "leftSkeletonSemi1";
            this.leftSkeletonSemi1.Size = new System.Drawing.Size(41, 13);
            this.leftSkeletonSemi1.TabIndex = 16;
            this.leftSkeletonSemi1.Text = "label11";
            this.leftSkeletonSemi1.Visible = false;
            // 
            // leftSkeletonSemi2
            // 
            this.leftSkeletonSemi2.AutoSize = true;
            this.leftSkeletonSemi2.Location = new System.Drawing.Point(720, 265);
            this.leftSkeletonSemi2.Name = "leftSkeletonSemi2";
            this.leftSkeletonSemi2.Size = new System.Drawing.Size(41, 13);
            this.leftSkeletonSemi2.TabIndex = 17;
            this.leftSkeletonSemi2.Text = "label12";
            this.leftSkeletonSemi2.Visible = false;
            // 
            // rightSkeletonSemi1
            // 
            this.rightSkeletonSemi1.AutoSize = true;
            this.rightSkeletonSemi1.Location = new System.Drawing.Point(947, 121);
            this.rightSkeletonSemi1.Name = "rightSkeletonSemi1";
            this.rightSkeletonSemi1.Size = new System.Drawing.Size(41, 13);
            this.rightSkeletonSemi1.TabIndex = 18;
            this.rightSkeletonSemi1.Text = "label13";
            this.rightSkeletonSemi1.Visible = false;
            // 
            // rightSkeletonSemi2
            // 
            this.rightSkeletonSemi2.AutoSize = true;
            this.rightSkeletonSemi2.Location = new System.Drawing.Point(947, 265);
            this.rightSkeletonSemi2.Name = "rightSkeletonSemi2";
            this.rightSkeletonSemi2.Size = new System.Drawing.Size(41, 13);
            this.rightSkeletonSemi2.TabIndex = 19;
            this.rightSkeletonSemi2.Text = "label14";
            this.rightSkeletonSemi2.Visible = false;
            // 
            // leftSkeletonFinal
            // 
            this.leftSkeletonFinal.AutoSize = true;
            this.leftSkeletonFinal.Location = new System.Drawing.Point(832, 242);
            this.leftSkeletonFinal.Name = "leftSkeletonFinal";
            this.leftSkeletonFinal.Size = new System.Drawing.Size(41, 13);
            this.leftSkeletonFinal.TabIndex = 20;
            this.leftSkeletonFinal.Text = "label15";
            this.leftSkeletonFinal.Visible = false;
            // 
            // rightSkeletonFinal
            // 
            this.rightSkeletonFinal.AutoSize = true;
            this.rightSkeletonFinal.Location = new System.Drawing.Point(832, 144);
            this.rightSkeletonFinal.Name = "rightSkeletonFinal";
            this.rightSkeletonFinal.Size = new System.Drawing.Size(41, 13);
            this.rightSkeletonFinal.TabIndex = 21;
            this.rightSkeletonFinal.Text = "label16";
            this.rightSkeletonFinal.Visible = false;
            // 
            // winnerOfTheTour
            // 
            this.winnerOfTheTour.AutoSize = true;
            this.winnerOfTheTour.Location = new System.Drawing.Point(54, 349);
            this.winnerOfTheTour.Name = "winnerOfTheTour";
            this.winnerOfTheTour.Size = new System.Drawing.Size(127, 13);
            this.winnerOfTheTour.TabIndex = 22;
            this.winnerOfTheTour.Text = "Winner of the tournament";
            this.winnerOfTheTour.Visible = false;
            // 
            // LSQ1
            // 
            this.LSQ1.AutoSize = true;
            this.LSQ1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LSQ1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LSQ1.Location = new System.Drawing.Point(611, 110);
            this.LSQ1.Name = "LSQ1";
            this.LSQ1.Size = new System.Drawing.Size(13, 13);
            this.LSQ1.TabIndex = 23;
            this.LSQ1.Text = "0";
            // 
            // LG1Q1
            // 
            this.LG1Q1.AutoSize = true;
            this.LG1Q1.Location = new System.Drawing.Point(630, 110);
            this.LG1Q1.Name = "LG1Q1";
            this.LG1Q1.Size = new System.Drawing.Size(13, 13);
            this.LG1Q1.TabIndex = 24;
            this.LG1Q1.Text = "0";
            // 
            // LG2Q1
            // 
            this.LG2Q1.AutoSize = true;
            this.LG2Q1.Location = new System.Drawing.Point(649, 110);
            this.LG2Q1.Name = "LG2Q1";
            this.LG2Q1.Size = new System.Drawing.Size(13, 13);
            this.LG2Q1.TabIndex = 25;
            this.LG2Q1.Text = "0";
            // 
            // LG3Q1
            // 
            this.LG3Q1.AutoSize = true;
            this.LG3Q1.Location = new System.Drawing.Point(668, 110);
            this.LG3Q1.Name = "LG3Q1";
            this.LG3Q1.Size = new System.Drawing.Size(13, 13);
            this.LG3Q1.TabIndex = 26;
            this.LG3Q1.Text = "0";
            // 
            // LG3Q2
            // 
            this.LG3Q2.AutoSize = true;
            this.LG3Q2.Location = new System.Drawing.Point(668, 134);
            this.LG3Q2.Name = "LG3Q2";
            this.LG3Q2.Size = new System.Drawing.Size(13, 13);
            this.LG3Q2.TabIndex = 30;
            this.LG3Q2.Text = "0";
            // 
            // LG2Q2
            // 
            this.LG2Q2.AutoSize = true;
            this.LG2Q2.Location = new System.Drawing.Point(649, 134);
            this.LG2Q2.Name = "LG2Q2";
            this.LG2Q2.Size = new System.Drawing.Size(13, 13);
            this.LG2Q2.TabIndex = 29;
            this.LG2Q2.Text = "0";
            // 
            // LG1Q2
            // 
            this.LG1Q2.AutoSize = true;
            this.LG1Q2.Location = new System.Drawing.Point(630, 134);
            this.LG1Q2.Name = "LG1Q2";
            this.LG1Q2.Size = new System.Drawing.Size(13, 13);
            this.LG1Q2.TabIndex = 28;
            this.LG1Q2.Text = "0";
            // 
            // LSQ2
            // 
            this.LSQ2.AutoSize = true;
            this.LSQ2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LSQ2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LSQ2.Location = new System.Drawing.Point(611, 134);
            this.LSQ2.Name = "LSQ2";
            this.LSQ2.Size = new System.Drawing.Size(13, 13);
            this.LSQ2.TabIndex = 27;
            this.LSQ2.Text = "0";
            // 
            // LG3Q3
            // 
            this.LG3Q3.AutoSize = true;
            this.LG3Q3.Location = new System.Drawing.Point(668, 254);
            this.LG3Q3.Name = "LG3Q3";
            this.LG3Q3.Size = new System.Drawing.Size(13, 13);
            this.LG3Q3.TabIndex = 34;
            this.LG3Q3.Text = "0";
            // 
            // LG2Q3
            // 
            this.LG2Q3.AutoSize = true;
            this.LG2Q3.Location = new System.Drawing.Point(649, 254);
            this.LG2Q3.Name = "LG2Q3";
            this.LG2Q3.Size = new System.Drawing.Size(13, 13);
            this.LG2Q3.TabIndex = 33;
            this.LG2Q3.Text = "0";
            // 
            // LG1Q3
            // 
            this.LG1Q3.AutoSize = true;
            this.LG1Q3.Location = new System.Drawing.Point(630, 254);
            this.LG1Q3.Name = "LG1Q3";
            this.LG1Q3.Size = new System.Drawing.Size(13, 13);
            this.LG1Q3.TabIndex = 32;
            this.LG1Q3.Text = "0";
            // 
            // LSQ3
            // 
            this.LSQ3.AutoSize = true;
            this.LSQ3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LSQ3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LSQ3.Location = new System.Drawing.Point(611, 254);
            this.LSQ3.Name = "LSQ3";
            this.LSQ3.Size = new System.Drawing.Size(13, 13);
            this.LSQ3.TabIndex = 31;
            this.LSQ3.Text = "0";
            // 
            // LG3Q4
            // 
            this.LG3Q4.AutoSize = true;
            this.LG3Q4.Location = new System.Drawing.Point(668, 277);
            this.LG3Q4.Name = "LG3Q4";
            this.LG3Q4.Size = new System.Drawing.Size(13, 13);
            this.LG3Q4.TabIndex = 38;
            this.LG3Q4.Text = "0";
            // 
            // LG2Q4
            // 
            this.LG2Q4.AutoSize = true;
            this.LG2Q4.Location = new System.Drawing.Point(649, 277);
            this.LG2Q4.Name = "LG2Q4";
            this.LG2Q4.Size = new System.Drawing.Size(13, 13);
            this.LG2Q4.TabIndex = 37;
            this.LG2Q4.Text = "0";
            // 
            // LG1Q4
            // 
            this.LG1Q4.AutoSize = true;
            this.LG1Q4.Location = new System.Drawing.Point(630, 277);
            this.LG1Q4.Name = "LG1Q4";
            this.LG1Q4.Size = new System.Drawing.Size(13, 13);
            this.LG1Q4.TabIndex = 36;
            this.LG1Q4.Text = "0";
            // 
            // LSQ4
            // 
            this.LSQ4.AutoSize = true;
            this.LSQ4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LSQ4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LSQ4.Location = new System.Drawing.Point(611, 277);
            this.LSQ4.Name = "LSQ4";
            this.LSQ4.Size = new System.Drawing.Size(13, 13);
            this.LSQ4.TabIndex = 35;
            this.LSQ4.Text = "0";
            // 
            // LG3S1
            // 
            this.LG3S1.AutoSize = true;
            this.LG3S1.Location = new System.Drawing.Point(780, 185);
            this.LG3S1.Name = "LG3S1";
            this.LG3S1.Size = new System.Drawing.Size(13, 13);
            this.LG3S1.TabIndex = 42;
            this.LG3S1.Text = "0";
            // 
            // LG2S1
            // 
            this.LG2S1.AutoSize = true;
            this.LG2S1.Location = new System.Drawing.Point(761, 185);
            this.LG2S1.Name = "LG2S1";
            this.LG2S1.Size = new System.Drawing.Size(13, 13);
            this.LG2S1.TabIndex = 41;
            this.LG2S1.Text = "0";
            // 
            // LG1S1
            // 
            this.LG1S1.AutoSize = true;
            this.LG1S1.Location = new System.Drawing.Point(742, 185);
            this.LG1S1.Name = "LG1S1";
            this.LG1S1.Size = new System.Drawing.Size(13, 13);
            this.LG1S1.TabIndex = 40;
            this.LG1S1.Text = "0";
            // 
            // LSS1
            // 
            this.LSS1.AutoSize = true;
            this.LSS1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LSS1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LSS1.Location = new System.Drawing.Point(723, 185);
            this.LSS1.Name = "LSS1";
            this.LSS1.Size = new System.Drawing.Size(13, 13);
            this.LSS1.TabIndex = 39;
            this.LSS1.Text = "0";
            // 
            // LG3S2
            // 
            this.LG3S2.AutoSize = true;
            this.LG3S2.Location = new System.Drawing.Point(780, 209);
            this.LG3S2.Name = "LG3S2";
            this.LG3S2.Size = new System.Drawing.Size(13, 13);
            this.LG3S2.TabIndex = 46;
            this.LG3S2.Text = "0";
            // 
            // LG2S2
            // 
            this.LG2S2.AutoSize = true;
            this.LG2S2.Location = new System.Drawing.Point(761, 209);
            this.LG2S2.Name = "LG2S2";
            this.LG2S2.Size = new System.Drawing.Size(13, 13);
            this.LG2S2.TabIndex = 45;
            this.LG2S2.Text = "0";
            // 
            // LG1S2
            // 
            this.LG1S2.AutoSize = true;
            this.LG1S2.Location = new System.Drawing.Point(742, 209);
            this.LG1S2.Name = "LG1S2";
            this.LG1S2.Size = new System.Drawing.Size(13, 13);
            this.LG1S2.TabIndex = 44;
            this.LG1S2.Text = "0";
            // 
            // LSS2
            // 
            this.LSS2.AutoSize = true;
            this.LSS2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LSS2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LSS2.Location = new System.Drawing.Point(723, 209);
            this.LSS2.Name = "LSS2";
            this.LSS2.Size = new System.Drawing.Size(13, 13);
            this.LSS2.TabIndex = 43;
            this.LSS2.Text = "0";
            // 
            // RG3Q1
            // 
            this.RG3Q1.AutoSize = true;
            this.RG3Q1.Location = new System.Drawing.Point(1122, 110);
            this.RG3Q1.Name = "RG3Q1";
            this.RG3Q1.Size = new System.Drawing.Size(13, 13);
            this.RG3Q1.TabIndex = 50;
            this.RG3Q1.Text = "0";
            // 
            // RG2Q1
            // 
            this.RG2Q1.AutoSize = true;
            this.RG2Q1.Location = new System.Drawing.Point(1103, 110);
            this.RG2Q1.Name = "RG2Q1";
            this.RG2Q1.Size = new System.Drawing.Size(13, 13);
            this.RG2Q1.TabIndex = 49;
            this.RG2Q1.Text = "0";
            // 
            // RG1Q1
            // 
            this.RG1Q1.AutoSize = true;
            this.RG1Q1.Location = new System.Drawing.Point(1084, 110);
            this.RG1Q1.Name = "RG1Q1";
            this.RG1Q1.Size = new System.Drawing.Size(13, 13);
            this.RG1Q1.TabIndex = 48;
            this.RG1Q1.Text = "0";
            // 
            // RSQ1
            // 
            this.RSQ1.AutoSize = true;
            this.RSQ1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.RSQ1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RSQ1.Location = new System.Drawing.Point(1065, 110);
            this.RSQ1.Name = "RSQ1";
            this.RSQ1.Size = new System.Drawing.Size(13, 13);
            this.RSQ1.TabIndex = 47;
            this.RSQ1.Text = "0";
            // 
            // RG3Q2
            // 
            this.RG3Q2.AutoSize = true;
            this.RG3Q2.Location = new System.Drawing.Point(1122, 134);
            this.RG3Q2.Name = "RG3Q2";
            this.RG3Q2.Size = new System.Drawing.Size(13, 13);
            this.RG3Q2.TabIndex = 54;
            this.RG3Q2.Text = "0";
            // 
            // RG2Q2
            // 
            this.RG2Q2.AutoSize = true;
            this.RG2Q2.Location = new System.Drawing.Point(1103, 134);
            this.RG2Q2.Name = "RG2Q2";
            this.RG2Q2.Size = new System.Drawing.Size(13, 13);
            this.RG2Q2.TabIndex = 53;
            this.RG2Q2.Text = "0";
            // 
            // RG1Q2
            // 
            this.RG1Q2.AutoSize = true;
            this.RG1Q2.Location = new System.Drawing.Point(1084, 134);
            this.RG1Q2.Name = "RG1Q2";
            this.RG1Q2.Size = new System.Drawing.Size(13, 13);
            this.RG1Q2.TabIndex = 52;
            this.RG1Q2.Text = "0";
            // 
            // RSQ2
            // 
            this.RSQ2.AutoSize = true;
            this.RSQ2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.RSQ2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RSQ2.Location = new System.Drawing.Point(1065, 134);
            this.RSQ2.Name = "RSQ2";
            this.RSQ2.Size = new System.Drawing.Size(13, 13);
            this.RSQ2.TabIndex = 51;
            this.RSQ2.Text = "0";
            // 
            // RG3Q3
            // 
            this.RG3Q3.AutoSize = true;
            this.RG3Q3.Location = new System.Drawing.Point(1122, 254);
            this.RG3Q3.Name = "RG3Q3";
            this.RG3Q3.Size = new System.Drawing.Size(13, 13);
            this.RG3Q3.TabIndex = 58;
            this.RG3Q3.Text = "0";
            // 
            // RG2Q3
            // 
            this.RG2Q3.AutoSize = true;
            this.RG2Q3.Location = new System.Drawing.Point(1103, 254);
            this.RG2Q3.Name = "RG2Q3";
            this.RG2Q3.Size = new System.Drawing.Size(13, 13);
            this.RG2Q3.TabIndex = 57;
            this.RG2Q3.Text = "0";
            // 
            // RG1Q3
            // 
            this.RG1Q3.AutoSize = true;
            this.RG1Q3.Location = new System.Drawing.Point(1084, 254);
            this.RG1Q3.Name = "RG1Q3";
            this.RG1Q3.Size = new System.Drawing.Size(13, 13);
            this.RG1Q3.TabIndex = 56;
            this.RG1Q3.Text = "0";
            // 
            // RSQ3
            // 
            this.RSQ3.AutoSize = true;
            this.RSQ3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.RSQ3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RSQ3.Location = new System.Drawing.Point(1065, 254);
            this.RSQ3.Name = "RSQ3";
            this.RSQ3.Size = new System.Drawing.Size(13, 13);
            this.RSQ3.TabIndex = 55;
            this.RSQ3.Text = "0";
            // 
            // RG3Q4
            // 
            this.RG3Q4.AutoSize = true;
            this.RG3Q4.Location = new System.Drawing.Point(1122, 277);
            this.RG3Q4.Name = "RG3Q4";
            this.RG3Q4.Size = new System.Drawing.Size(13, 13);
            this.RG3Q4.TabIndex = 62;
            this.RG3Q4.Text = "0";
            // 
            // RG2Q4
            // 
            this.RG2Q4.AutoSize = true;
            this.RG2Q4.Location = new System.Drawing.Point(1103, 277);
            this.RG2Q4.Name = "RG2Q4";
            this.RG2Q4.Size = new System.Drawing.Size(13, 13);
            this.RG2Q4.TabIndex = 61;
            this.RG2Q4.Text = "0";
            // 
            // RG1Q4
            // 
            this.RG1Q4.AutoSize = true;
            this.RG1Q4.Location = new System.Drawing.Point(1084, 277);
            this.RG1Q4.Name = "RG1Q4";
            this.RG1Q4.Size = new System.Drawing.Size(13, 13);
            this.RG1Q4.TabIndex = 60;
            this.RG1Q4.Text = "0";
            // 
            // RSQ4
            // 
            this.RSQ4.AutoSize = true;
            this.RSQ4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.RSQ4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RSQ4.Location = new System.Drawing.Point(1065, 277);
            this.RSQ4.Name = "RSQ4";
            this.RSQ4.Size = new System.Drawing.Size(13, 13);
            this.RSQ4.TabIndex = 59;
            this.RSQ4.Text = "0";
            // 
            // RG3S1
            // 
            this.RG3S1.AutoSize = true;
            this.RG3S1.Location = new System.Drawing.Point(1012, 185);
            this.RG3S1.Name = "RG3S1";
            this.RG3S1.Size = new System.Drawing.Size(13, 13);
            this.RG3S1.TabIndex = 66;
            this.RG3S1.Text = "0";
            // 
            // RG2S1
            // 
            this.RG2S1.AutoSize = true;
            this.RG2S1.Location = new System.Drawing.Point(993, 185);
            this.RG2S1.Name = "RG2S1";
            this.RG2S1.Size = new System.Drawing.Size(13, 13);
            this.RG2S1.TabIndex = 65;
            this.RG2S1.Text = "0";
            // 
            // RG1S1
            // 
            this.RG1S1.AutoSize = true;
            this.RG1S1.Location = new System.Drawing.Point(974, 185);
            this.RG1S1.Name = "RG1S1";
            this.RG1S1.Size = new System.Drawing.Size(13, 13);
            this.RG1S1.TabIndex = 64;
            this.RG1S1.Text = "0";
            // 
            // RSS1
            // 
            this.RSS1.AutoSize = true;
            this.RSS1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.RSS1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RSS1.Location = new System.Drawing.Point(955, 185);
            this.RSS1.Name = "RSS1";
            this.RSS1.Size = new System.Drawing.Size(13, 13);
            this.RSS1.TabIndex = 63;
            this.RSS1.Text = "0";
            // 
            // RG3S2
            // 
            this.RG3S2.AutoSize = true;
            this.RG3S2.Location = new System.Drawing.Point(1012, 209);
            this.RG3S2.Name = "RG3S2";
            this.RG3S2.Size = new System.Drawing.Size(13, 13);
            this.RG3S2.TabIndex = 70;
            this.RG3S2.Text = "0";
            // 
            // RG2S2
            // 
            this.RG2S2.AutoSize = true;
            this.RG2S2.Location = new System.Drawing.Point(993, 209);
            this.RG2S2.Name = "RG2S2";
            this.RG2S2.Size = new System.Drawing.Size(13, 13);
            this.RG2S2.TabIndex = 69;
            this.RG2S2.Text = "0";
            // 
            // RG1S2
            // 
            this.RG1S2.AutoSize = true;
            this.RG1S2.Location = new System.Drawing.Point(974, 209);
            this.RG1S2.Name = "RG1S2";
            this.RG1S2.Size = new System.Drawing.Size(13, 13);
            this.RG1S2.TabIndex = 68;
            this.RG1S2.Text = "0";
            // 
            // RSS2
            // 
            this.RSS2.AutoSize = true;
            this.RSS2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.RSS2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RSS2.Location = new System.Drawing.Point(955, 209);
            this.RSS2.Name = "RSS2";
            this.RSS2.Size = new System.Drawing.Size(13, 13);
            this.RSS2.TabIndex = 67;
            this.RSS2.Text = "0";
            // 
            // LG3F1
            // 
            this.LG3F1.AutoSize = true;
            this.LG3F1.Location = new System.Drawing.Point(894, 209);
            this.LG3F1.Name = "LG3F1";
            this.LG3F1.Size = new System.Drawing.Size(13, 13);
            this.LG3F1.TabIndex = 74;
            this.LG3F1.Text = "0";
            // 
            // LG2F1
            // 
            this.LG2F1.AutoSize = true;
            this.LG2F1.Location = new System.Drawing.Point(875, 209);
            this.LG2F1.Name = "LG2F1";
            this.LG2F1.Size = new System.Drawing.Size(13, 13);
            this.LG2F1.TabIndex = 73;
            this.LG2F1.Text = "0";
            // 
            // LG1F1
            // 
            this.LG1F1.AutoSize = true;
            this.LG1F1.Location = new System.Drawing.Point(856, 209);
            this.LG1F1.Name = "LG1F1";
            this.LG1F1.Size = new System.Drawing.Size(13, 13);
            this.LG1F1.TabIndex = 72;
            this.LG1F1.Text = "0";
            // 
            // LSF1
            // 
            this.LSF1.AutoSize = true;
            this.LSF1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LSF1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LSF1.Location = new System.Drawing.Point(837, 209);
            this.LSF1.Name = "LSF1";
            this.LSF1.Size = new System.Drawing.Size(13, 13);
            this.LSF1.TabIndex = 71;
            this.LSF1.Text = "0";
            // 
            // RG3F1
            // 
            this.RG3F1.AutoSize = true;
            this.RG3F1.Location = new System.Drawing.Point(894, 185);
            this.RG3F1.Name = "RG3F1";
            this.RG3F1.Size = new System.Drawing.Size(13, 13);
            this.RG3F1.TabIndex = 78;
            this.RG3F1.Text = "0";
            // 
            // RG2F1
            // 
            this.RG2F1.AutoSize = true;
            this.RG2F1.Location = new System.Drawing.Point(875, 185);
            this.RG2F1.Name = "RG2F1";
            this.RG2F1.Size = new System.Drawing.Size(13, 13);
            this.RG2F1.TabIndex = 77;
            this.RG2F1.Text = "0";
            // 
            // RG1F1
            // 
            this.RG1F1.AutoSize = true;
            this.RG1F1.Location = new System.Drawing.Point(856, 185);
            this.RG1F1.Name = "RG1F1";
            this.RG1F1.Size = new System.Drawing.Size(13, 13);
            this.RG1F1.TabIndex = 76;
            this.RG1F1.Text = "0";
            // 
            // RSF1
            // 
            this.RSF1.AutoSize = true;
            this.RSF1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.RSF1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RSF1.Location = new System.Drawing.Point(837, 185);
            this.RSF1.Name = "RSF1";
            this.RSF1.Size = new System.Drawing.Size(13, 13);
            this.RSF1.TabIndex = 75;
            this.RSF1.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1178, 625);
            this.Controls.Add(this.RG3F1);
            this.Controls.Add(this.RG2F1);
            this.Controls.Add(this.RG1F1);
            this.Controls.Add(this.RSF1);
            this.Controls.Add(this.LG3F1);
            this.Controls.Add(this.LG2F1);
            this.Controls.Add(this.LG1F1);
            this.Controls.Add(this.LSF1);
            this.Controls.Add(this.RG3S2);
            this.Controls.Add(this.RG2S2);
            this.Controls.Add(this.RG1S2);
            this.Controls.Add(this.RSS2);
            this.Controls.Add(this.RG3S1);
            this.Controls.Add(this.RG2S1);
            this.Controls.Add(this.RG1S1);
            this.Controls.Add(this.RSS1);
            this.Controls.Add(this.RG3Q4);
            this.Controls.Add(this.RG2Q4);
            this.Controls.Add(this.RG1Q4);
            this.Controls.Add(this.RSQ4);
            this.Controls.Add(this.RG3Q3);
            this.Controls.Add(this.RG2Q3);
            this.Controls.Add(this.RG1Q3);
            this.Controls.Add(this.RSQ3);
            this.Controls.Add(this.RG3Q2);
            this.Controls.Add(this.RG2Q2);
            this.Controls.Add(this.RG1Q2);
            this.Controls.Add(this.RSQ2);
            this.Controls.Add(this.RG3Q1);
            this.Controls.Add(this.RG2Q1);
            this.Controls.Add(this.RG1Q1);
            this.Controls.Add(this.RSQ1);
            this.Controls.Add(this.LG3S2);
            this.Controls.Add(this.LG2S2);
            this.Controls.Add(this.LG1S2);
            this.Controls.Add(this.LSS2);
            this.Controls.Add(this.LG3S1);
            this.Controls.Add(this.LG2S1);
            this.Controls.Add(this.LG1S1);
            this.Controls.Add(this.LSS1);
            this.Controls.Add(this.LG3Q4);
            this.Controls.Add(this.LG2Q4);
            this.Controls.Add(this.LG1Q4);
            this.Controls.Add(this.LSQ4);
            this.Controls.Add(this.LG3Q3);
            this.Controls.Add(this.LG2Q3);
            this.Controls.Add(this.LG1Q3);
            this.Controls.Add(this.LSQ3);
            this.Controls.Add(this.LG3Q2);
            this.Controls.Add(this.LG2Q2);
            this.Controls.Add(this.LG1Q2);
            this.Controls.Add(this.LSQ2);
            this.Controls.Add(this.LG3Q1);
            this.Controls.Add(this.LG2Q1);
            this.Controls.Add(this.LG1Q1);
            this.Controls.Add(this.LSQ1);
            this.Controls.Add(this.winnerOfTheTour);
            this.Controls.Add(this.rightSkeletonFinal);
            this.Controls.Add(this.leftSkeletonFinal);
            this.Controls.Add(this.rightSkeletonSemi2);
            this.Controls.Add(this.rightSkeletonSemi1);
            this.Controls.Add(this.leftSkeletonSemi2);
            this.Controls.Add(this.leftSkeletonSemi1);
            this.Controls.Add(this.rightSkeletonQuarter4);
            this.Controls.Add(this.rightSkeletonQuarter3);
            this.Controls.Add(this.rightSkeletonQuarter2);
            this.Controls.Add(this.rightSkeletonQuarter1);
            this.Controls.Add(this.leftSkeletonQuarter4);
            this.Controls.Add(this.leftSkeletonQuarter3);
            this.Controls.Add(this.leftSkeletonQuarter2);
            this.Controls.Add(this.leftSkeletonQuarter1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.winnerName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.start);
            this.Controls.Add(this.listView1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Match";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader state;
        private System.Windows.Forms.ColumnHeader player;
        private System.Windows.Forms.ColumnHeader points;
        private System.Windows.Forms.ColumnHeader ranking;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label winnerName;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label leftSkeletonQuarter1;
        private System.Windows.Forms.Label leftSkeletonQuarter2;
        private System.Windows.Forms.Label leftSkeletonQuarter3;
        private System.Windows.Forms.Label leftSkeletonQuarter4;
        private System.Windows.Forms.Label rightSkeletonQuarter1;
        private System.Windows.Forms.Label rightSkeletonQuarter2;
        private System.Windows.Forms.Label rightSkeletonQuarter3;
        private System.Windows.Forms.Label rightSkeletonQuarter4;
        private System.Windows.Forms.Label leftSkeletonSemi1;
        private System.Windows.Forms.Label leftSkeletonSemi2;
        private System.Windows.Forms.Label rightSkeletonSemi1;
        private System.Windows.Forms.Label rightSkeletonSemi2;
        private System.Windows.Forms.Label leftSkeletonFinal;
        private System.Windows.Forms.Label rightSkeletonFinal;
        private System.Windows.Forms.Label winnerOfTheTour;
        private System.Windows.Forms.Label LSQ1;
        private System.Windows.Forms.Label LG1Q1;
        private System.Windows.Forms.Label LG2Q1;
        private System.Windows.Forms.Label LG3Q1;
        private System.Windows.Forms.Label LG3Q2;
        private System.Windows.Forms.Label LG2Q2;
        private System.Windows.Forms.Label LG1Q2;
        private System.Windows.Forms.Label LSQ2;
        private System.Windows.Forms.Label LG3Q3;
        private System.Windows.Forms.Label LG2Q3;
        private System.Windows.Forms.Label LG1Q3;
        private System.Windows.Forms.Label LSQ3;
        private System.Windows.Forms.Label LG3Q4;
        private System.Windows.Forms.Label LG2Q4;
        private System.Windows.Forms.Label LG1Q4;
        private System.Windows.Forms.Label LSQ4;
        private System.Windows.Forms.Label LG3S1;
        private System.Windows.Forms.Label LG2S1;
        private System.Windows.Forms.Label LG1S1;
        private System.Windows.Forms.Label LSS1;
        private System.Windows.Forms.Label LG3S2;
        private System.Windows.Forms.Label LG2S2;
        private System.Windows.Forms.Label LG1S2;
        private System.Windows.Forms.Label LSS2;
        private System.Windows.Forms.Label RG3Q1;
        private System.Windows.Forms.Label RG2Q1;
        private System.Windows.Forms.Label RG1Q1;
        private System.Windows.Forms.Label RSQ1;
        private System.Windows.Forms.Label RG3Q2;
        private System.Windows.Forms.Label RG2Q2;
        private System.Windows.Forms.Label RG1Q2;
        private System.Windows.Forms.Label RSQ2;
        private System.Windows.Forms.Label RG3Q3;
        private System.Windows.Forms.Label RG2Q3;
        private System.Windows.Forms.Label RG1Q3;
        private System.Windows.Forms.Label RSQ3;
        private System.Windows.Forms.Label RG3Q4;
        private System.Windows.Forms.Label RG2Q4;
        private System.Windows.Forms.Label RG1Q4;
        private System.Windows.Forms.Label RSQ4;
        private System.Windows.Forms.Label RG3S1;
        private System.Windows.Forms.Label RG2S1;
        private System.Windows.Forms.Label RG1S1;
        private System.Windows.Forms.Label RSS1;
        private System.Windows.Forms.Label RG3S2;
        private System.Windows.Forms.Label RG2S2;
        private System.Windows.Forms.Label RG1S2;
        private System.Windows.Forms.Label RSS2;
        private System.Windows.Forms.Label LG3F1;
        private System.Windows.Forms.Label LG2F1;
        private System.Windows.Forms.Label LG1F1;
        private System.Windows.Forms.Label LSF1;
        private System.Windows.Forms.Label RG3F1;
        private System.Windows.Forms.Label RG2F1;
        private System.Windows.Forms.Label RG1F1;
        private System.Windows.Forms.Label RSF1;
    }
}

