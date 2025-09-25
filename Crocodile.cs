using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YehonatanShlain_Zoo
{
    internal class Crocodile : Reptile
    {
        private bool WentToDentist;
        public Crocodile(bool wentToDentist) : base(1.5, false, "Warm")
        {
            WentToDentist = wentToDentist;
        }
        public bool GetWentToDentist() { return WentToDentist; }
        public void SetWentToDentist(bool wentToDentist) { WentToDentist = wentToDentist; }
        public override double Eat() { return base.Eat() * 0.5; }
        public override string ToString()
        {
            return base.ToString() + ", Went to dentist: " + WentToDentist;
        }
    }
}
