using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymSystem
{
    internal class Class
    {
        public string Name { get; set; }
        public string Schedule { get; set; }
        public int Capacity { get; set; }
        public string TrainerName { get; set; }
        public List<string> EnrolledMember { get; set; } = new List<string>();
        public Class(string name, string schedule, int capacity, string trainerMember)
        {
            Name = name;
            Schedule = schedule;
            Capacity = capacity;
            TrainerName = trainerMember;
        }
        public Class() { }
        public string ScheduleClass()
        {
            return $"Name : {Name} , with trainerName : {TrainerName} , On : {Schedule}";
        }
    }
}
