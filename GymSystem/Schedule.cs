using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymSystem
{
    internal class Schedule : Class
    {
        public void DisplayAllSch(LinkedList<string> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{list.ElementAt(i)}");
            }
        }
    }
}
