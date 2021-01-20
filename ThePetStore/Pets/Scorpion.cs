﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ThePetStore.Pets
{
    //A class is implicitly internal -- public and internal work the same way, for now...
    public class Scorpion
    {
        // inside class things are implicitly private
        public int StingerWidth { get; set; }
        public string Origin { get; set; }
        public string Name { get; set; }
        public bool DoesGlow { get; set; }

        //Constructor
        public Scorpion(string name)
        {
            Name = name;
            DoesGlow = true;
        }

        //Methods
        public void Attack()
        {
            if (DoesGlow)
            {
                Console.WriteLine("Scorpion attacks! Get to the hospital");
            }
            else
            {
                Console.WriteLine("Scorpion does a kick flip. Rad!");
            }
        }

    }
}
