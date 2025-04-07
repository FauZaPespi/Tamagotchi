using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_Tamagotchi.Game
{
    class Caca : Item
    {
        private int _saturation;
        public Caca(string name, string texture, int saturation) : base(name, texture)
        {
            _saturation = saturation;
        }

        public int Saturation { get; set; }
    }
}
