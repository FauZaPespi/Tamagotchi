using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_Tamagotchi.Game
{
    public class Food : Item
    {
        public int Saturation { get; set; }
        public Food(string name, string texture, int saturation) : base(name, texture)
        {
            Saturation = saturation;
        }
    }
}
