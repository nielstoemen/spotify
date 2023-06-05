using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spotify1
{
    public class artist
    {

        public string Name { get; set; }
        List<int> Albums = new List<int>();
        List<int> Songs = new List<int>();


        public artist(string naam) 
        { 
            Name = naam;
        }
    }
}
