using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YehonatanShlain_Zoo
{
    internal class Labrador : Mammal
    {
        private Person PersonToGuide;
        public Labrador(Person personToGuide)
            : base(25, 2, "unknown labrador", "unknown", 1500, false, new Date(1, 1, 2000))
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
