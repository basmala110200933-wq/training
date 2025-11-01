using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymSystem
{
    internal class Member : Trainer
    {
        public string MName { get; set; }
        public int MAge { get; set; }
        public string MShipType { get; set; }
        public Member(string mName, int mAge, string mShipType)
        {
            MName = mName;
            MAge = mAge;
            MShipType = mShipType;
        }
        public string Register()
        {
            return $" Done Added Member :{MName} ,On : {DateTime.Today.ToLongTimeString()} ..with ShipType --> {MShipType}";
        }
    }
}
