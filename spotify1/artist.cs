using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spotify1
{
    public class artist
    {
        public int ID { get; set; }
        public string Name { get; set; }
        List<int> Albums = new List<int>();
        List<int> Songs = new List<int>();


        public artist(int id, string naam) 
        { 
            ID = id;
            Name = naam;
        }
    }
}
