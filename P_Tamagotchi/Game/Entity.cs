using P_Tamagotchi.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_Tamagotchi.Game
{
    public class Entity
    {
        public String Nom { get; set ; }
        public Sprite Sprite { get; set; }

        public Entity(string name, Sprite sprite)
        {
            Nom = name;
            Sprite = sprite;
        }
    }
}
