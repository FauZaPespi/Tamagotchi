using P_Tamagotchi.Resources;
using P_Tamagotchi.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static P_Tamagotchi.Utils.Tools;

namespace P_Tamagotchi.Game
{
    public class Tamagotchi : Entity
    {
        public int Hunger { get; set; }
        public int Health { get; set; }

        private int _banana;

        public int Banana
        {
            get { return _banana; }
            set { if (value >= 100) { _banana = value; } else { _banana = 100; } }
        }


        public int Age { get; set; }
        public bool isSleeping { get; set; }
        public bool isSick { get; set; }
        public int Discipline { get; set; }

        public string Name { get; set; }
        public Sprite Texture { get; }
        public bool isDead => Health <= 0;
        public Tamagotchi(string name, Sprite texture) : base(name, texture)
        {
            Name = name;
            Texture = texture;
            Hunger = 0;
            Health = 100;
            Age = 0;
        }
        /// <summary>
        /// Cette méthode réduit la faim du Tamagotchi. Elle simule l'action de nourrir le Tamagotchi, ce qui réduit son niveau de faim.
        /// </summary>
        public void Feed(Food food)
        {
            if (Hunger == 0 && Health < 100)
            {
                this.Eat(food);
            }
            Hunger = Math.Max(0, Hunger - food.Saturation);
        }

        public void GrowOlder()
        {
            Age++;
            Console.WriteLine(this.Nom + " is " + Age);
        }

        public void Damage(int damage)
        {
            Health -= damage;
        }

        public void Starvation()
        {

            if (Hunger > Health)
            {
                Health -= 5 * Hunger / 100;
            }
            Hunger += 15;
        }
        /// <summary>
        /// Cette méthode augmente la santé du Tamagotchi en fonction de la saturation de la nourriture consommée. Elle simule l'action de manger de la nourriture.
        /// </summary>
        /// <param name="food"></param>
        public void Eat(Food food)
        {
            Health += ((food.Saturation / Health) + 1);
        }

        public void Heal(int heal)
        {
            Health += heal;
            Health = Tools.LimitInclusive(Health, 0, 100);
        }
        public override string ToString()
        {
            return $"Tamagotchi:\n||Name: {Name}||\n - Hunger: {Hunger}\n - Health: {Health}\n - Age: {Age}\n - isSleeping: {isSleeping}\n - isSick: {isSick}\n - Discipline: {Discipline}\n - Texture: {Texture.GetSprite().Tag}";
        }
    }

}
