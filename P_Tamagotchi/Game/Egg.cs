using P_Tamagotchi.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_Tamagotchi.Game
{
    class Egg : Entity
    {
        private Tamagotchi _tamagotchi;
        private int _hatchLimit;
        private static Egg _instance;
        public Egg(string name, Sprite texture, Tamagotchi tamagotchi, int hatchLimit = 5) : base(name, texture)
        {
            _hatchLimit = hatchLimit;
            _tamagotchi = tamagotchi;

        }
        public void Hatch()
        {
            if (_tamagotchi != null)
            {
                GameManager.GetInstance().AddTamagotchis(_tamagotchi);
            }
        }
    }
}
