using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YehonatanShlain_Zoo
{
    internal class Dog : Mammal
    {
        private int BonesToEat;
        public Dog(int BonesToEat) : base(20, 2, "unknown dog", "unknown", 1000, true, new Date(1, 1, 2000))
        {
            this.BonesToEat = BonesToEat;
        }
        public int GetBonesToEat() { return BonesToEat; }
        public void SetBonesToEat(int bonesToEat) { BonesToEat = bonesToEat; }
        public override string ToString()
        {
            return base.ToString() + ", Bones to eat: " + BonesToEat;
        }
    }
}
