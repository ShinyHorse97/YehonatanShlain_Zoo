using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YehonatanShlain_Zoo
{
    internal class Iguana : Reptile
    {
        private bool isFriendly;
        public Iguana(bool isFriendly)
            : base(1.2, false, "Warm")
        {
            this.isFriendly = isFriendly;
        }
        public bool GetIsFriendly() { return isFriendly; }
        public void SetIsFriendly(bool isFriendly) { this.isFriendly = isFriendly; }
        public override string ToString()
        {
            return base.ToString() + ", Is friendly: " + isFriendly;
        }
    }
}
