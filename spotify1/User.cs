﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spotify1
{
    public  class User
    {
        public int UserID {  get; set; }
        public string Name { get; set; }

        List<int> friendlist = new List<int>();

        public User (int ID, string naam)
        {
            UserID = ID;
            Name = naam;
        }



    }
}
