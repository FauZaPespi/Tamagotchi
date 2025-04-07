using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_Tamagotchi.Game
{
    public class GameManager
    {
        private Stack<Action> actions = new Stack<Action>();

        private const int _tickRate = (1000 / 1); // 20 tick par seconde = (1000 / 20)
        private List<Tamagotchi> _tamagotchis = new List<Tamagotchi>();

        private int _currentIndex = 0;

        private GameManager() { }

        private int _worldAge = 0;

        private static GameManager _instance;

        private static readonly object _lock = new object();

        public static GameManager GetInstance()
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new GameManager();
                    }
                }
            }
            return _instance;
        }

        public void Update(int tick)
        {
            object locker = new object();
            Console.WriteLine("The stack have: " + actions.Count + " actions to execute");
            if (tick % 10 == 0)
            {
                _worldAge++;
                foreach (Tamagotchi tamagotchi in _tamagotchis)
                {
                    tamagotchi.GrowOlder();
                    tamagotchi.Starvation();
                }
                Console.WriteLine("World Age ++ now set to " + _worldAge);
            }
            lock (locker)
            {
                foreach (Tamagotchi tamagotchii in _tamagotchis)
                {
                    if (tamagotchii.isDead)
                    {
                        actions.Push(() =>
                        {
                            Console.WriteLine(tamagotchii.Name + " est mort");
                            _tamagotchis.Remove(tamagotchii);
                        });
                    }

                }
            }
            Console.WriteLine("ticked: nb" + tick);
            if (actions != null)
            {
                while (actions.Count > 0)
                {
                    try
                    {
                        actions.Pop().Invoke();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
            }
        }

        public int TickRate
        {
            get { return _tickRate; }
        }

        public List<Tamagotchi> GetTamagotchis()
        {
            return _tamagotchis;
        }

        /// <summary>
        /// Retourne le tamagotchi selon l'index
        /// Si l'index est egal a "-2" alors retourne le tamagotchi actuelle selectionné
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public Tamagotchi GetTamagotchi(int index = -2)
        {
            if (_tamagotchis.Count > 0)
            {
                if (index != -2)
                {
                    return _tamagotchis[index];
                }
                return _tamagotchis[_currentIndex];
            }
            return null;
        }

        public void SetTamagotchis(List<Tamagotchi> value)
        {
            _tamagotchis = value;
        }

        public void AddTamagotchis(Tamagotchi tamagotchi)
        {
            _tamagotchis.Add(tamagotchi);
        }

        public int GetCurrentIndex()
        {
            return _currentIndex;
        }
        public void SetCurrentIndex(int index)
        {
            _currentIndex = index;
        }
        public int GetWorldAge()
        {
            return _worldAge;
        }
        public int getIndexByName(string name)
        {
            foreach (Tamagotchi tamagotchi in _tamagotchis)
            {
                if (tamagotchi.Nom == name)
                {
                    return _tamagotchis.IndexOf(tamagotchi);
                }
            }
            return 0;
        }

        public void Heal(Tamagotchi tamagotchi, int heal)
        {
            actions.Push(() => { tamagotchi.Heal(heal); Console.WriteLine("Heal from stack executed"); });
            Console.WriteLine("Push to the stack actions (HEAL)");
        }

        public void Feed(Tamagotchi tamagotchi, Food food)
        {
            actions.Push(() => { tamagotchi.Feed(food); Console.WriteLine("Food from stack executed"); });
            Console.WriteLine("Push to the stack actions (FOOD)");
        }
    }
}
