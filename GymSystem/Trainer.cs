using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymSystem
{
    internal class Trainer
    {
        public string Name { get; set; }
        public string Expertise { get; set; }
        public Trainer(string name, string expertise)
        {
            Name = name;
            Expertise = expertise;
        }

        public Trainer() { }
        public void DisplayAllTra(Dictionary<string, string> trainer)
        {
            for (int i = 0; i < trainer.Count; i++)
            {
                Console.WriteLine($"{i + 1} . {trainer.ElementAt(i).Key} ..{trainer.ElementAt(i).Value} ");
            }
        }
    }
}
