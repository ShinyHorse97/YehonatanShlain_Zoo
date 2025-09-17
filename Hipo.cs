using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YehonatanShlain_Zoo
{
    internal class Hipo : Mammal
    {
        private double weight;
        private double FatPercentage;
        public Hipo(double weight, double fatPercentage)
            : base(50, 8, "unknown hipo", "unknown", 4000, false, new Date(1, 1, 2000))
        {
            this.weight = weight;
            this.FatPercentage = fatPercentage;
        }
        public double GetWeight() { return weight; }
        public double GetFatPercentage() { return FatPercentage; }
        public void SetWeight(double weight) { this.weight = weight; }
        public void SetFatPercentage(double fatPercentage) { FatPercentage = fatPercentage; }
        public override string ToString()
        {
            return base.ToString() + ", Weight: " + weight + ", Fat percentage: " + FatPercentage;
        }
    }
}
