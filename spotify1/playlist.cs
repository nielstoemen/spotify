using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spotify1
{
    public class playlist
    {
        public string PlaylistName { get; set; }
        public int PlaylistId { get; set; }
        public int PlaylistOwnerID { get; set; }
        public int SongCount { get; set; }
        public double PlaylistDuur { get; set; }

        public playlist(string name, int id, int ownerid, int countsong, double duurplaylist )
        {
            PlaylistName = name;
            PlaylistId = id;
            PlaylistOwnerID = ownerid;
            SongCount = countsong;
            PlaylistDuur = duurplaylist;

        }


    }
    }

