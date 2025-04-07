using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_Tamagotchi.Game
{
    class Medicament : Item
    {
        public int Health { get; set; }

        public Medicament(string name, string texture, int health) : base(name, texture)
        {
            Health = health;
        }
    }
}
