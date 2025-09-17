using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YehonatanShlain_Zoo
{
    internal class Labrador : Dog
    {
        private Person PersonToGuide;
        public Labrador(Person personToGuide)
            : base(0)
        {
            this.PersonToGuide = personToGuide;
        }
        public Person GetPersonToGuide() { return PersonToGuide; }
        public void SetPersonToGuide(Person personToGuide) { PersonToGuide = personToGuide; }
        public override string ToString()
        {
            return base.ToString() + ", Person to guide: " + PersonToGuide;
        }
    }
}
