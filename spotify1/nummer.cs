using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spotify1
{
    public class nummer
    {
        public string SongName { get; set; }
        public string SongArtiest { get; set; }

        public string Genre { get; set; }
        public int SongId { get; set; } 

        public double Duur { get; set; }

        public nummer(string songnaam, string songartiest, string genre, int songid, double duur)
        {
            SongName = songnaam;
            SongArtiest = songartiest;
            Genre = genre;
            SongId = songid;
            Duur = duur;

        }
        

    }
}
