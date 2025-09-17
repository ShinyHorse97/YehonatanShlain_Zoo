using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YehonatanShlain_Zoo
{
    internal class Boxer : Dog
    {
        private object ObjectToGuard;
        public Boxer(object objectToGuard)
            : base(0)
        {
            ObjectToGuard = objectToGuard;
        }
        public object GetObjectToGuard() { return ObjectToGuard; }
        public void SetObjectToGuard(object objectToGuard) { ObjectToGuard = objectToGuard; }
        public override string ToString()
        {
            return base.ToString() + ", Object to guard: " + ObjectToGuard;
        }
    }
}
