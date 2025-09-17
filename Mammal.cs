using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YehonatanShlain_Zoo
{
    internal class Mammal : Animal
    {
        private double CalInMilk;
        private int PregnancyDuration;
        public Mammal(double CalInMilk, int PregnancyDuration, string name, string gender, double calories, bool predator, Date dateOfBirth) : base(name, gender, calories, predator, dateOfBirth)
        {
            this.CalInMilk = CalInMilk;
            this.PregnancyDuration = PregnancyDuration;
        }
        public double GetCalInMilk() { return CalInMilk; }
        public int GetPregnancyDuration() { return PregnancyDuration; }
        public void SetCalInMilk(double calInMilk) { CalInMilk = calInMilk; }
        public void SetPregnancyDuration(int pregnancyDuration) { PregnancyDuration = pregnancyDuration; }
        public override string ToString()
        {
            return base.ToString() + ", Calories in milk: " + CalInMilk + ", Pregnancy duration: " + PregnancyDuration;
        }
    }
}
