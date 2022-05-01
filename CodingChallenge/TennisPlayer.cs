using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge
{
    class TennisPlayer
    {
        public Bitmap Picture { get; set; }
        public int Rank { get; set; }
        public string State { get; set; }
        public string NameAndSurname { get; set; }
        public int Pts { get; set;}

        public TennisPlayer(Bitmap pic, int r, string st, string n, int p) 
        {
            this.Picture = pic;
            this.Rank = r; 
            this.State = st; 
            this.NameAndSurname = n; 
            this.Pts = p;
        }
    }
}
