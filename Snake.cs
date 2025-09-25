using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YehonatanShlain_Zoo
{
    internal class Snake : Reptile
    {
        private bool IsPoisonous;
        public Snake(bool isPoisonous)
            : base(1.0, true, "Warm")
        {
            this.IsPoisonous = isPoisonous;
        }
        public bool GetIsPoisonous() { return IsPoisonous; }
        public void SetIsPoisonous(bool isPoisonous) { IsPoisonous = isPoisonous; }
        public void Dance()
        {
            Console.WriteLine("The snake is dancing");
        }
        public override string ToString()
        {
            return base.ToString() + "Is poisonous: " + IsPoisonous;
        }
    }
}
