using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_Tamagotchi.Game
{
    public class Item 
    {
        private string _name;
        private string _texture;

        public Item(string name, string texture)
        {
            _name = name;
            _texture = texture;
        }
    }
}
