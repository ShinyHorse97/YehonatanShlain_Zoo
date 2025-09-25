using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YehonatanShlain_Zoo
{
    internal class Cow : Mammal
    {
        private int NumOfCalves;
        private int MilkPerDay;
        private int NumOfSpots;
        public Cow(int NumOfCalves, int MilkPerDay, int NumOfSpots) : base(60, 9, "unknown cow", "unknown", 3000, false, new Date(1, 1, 2000))
        {
            this.NumOfCalves = NumOfCalves;
            this.MilkPerDay = MilkPerDay;
            this.NumOfSpots = NumOfSpots;
        }
        public int GetNumOfCalves() { return NumOfCalves; }
        public int GetMilkPerDay() { return MilkPerDay; }
        public int GetNumOfSpots() { return NumOfSpots; }
        public void SetNumOfCalves(int numOfCalves) { NumOfCalves = numOfCalves; }
        public void SetMilkPerDay(int milkPerDay) { MilkPerDay = milkPerDay; }
        public void SetNumOfSpots(int numOfSpots) { NumOfSpots = numOfSpots; }
        public override double Eat() { return base.Eat() * 0.25; }
        public override string ToString()
        {
            return base.ToString() + ", Number of calves: " + NumOfCalves + ", Milk per day: " + MilkPerDay + ", Number of spots: " + NumOfSpots;
        }
    }
}
