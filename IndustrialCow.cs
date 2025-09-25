using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YehonatanShlain_Zoo
{
    internal class IndustrialCow : Cow
    {
        private double milkProductionPerDay; 
        private double weight; 
        private string breed;
        public IndustrialCow(double milkProductionPerDay, double weight, string breed)
            : base(0, 0, 0)
        {
            this.milkProductionPerDay = milkProductionPerDay;
            this.weight = weight;
            this.breed = breed;
        }
        public double GetMilkProductionPerDay() { return milkProductionPerDay; }
        public double GetWeight() { return weight; }
        public string GetBreed() { return breed; }
        public void SetMilkProductionPerDay(double milkProductionPerDay) { this.milkProductionPerDay = milkProductionPerDay; }
        public void SetWeight(double weight) { this.weight = weight; }
        public void SetBreed(string breed) { this.breed = breed; }
        public override string ToString()
        {
            return "Industrial Cow: " + ", Milk production per day: " + milkProductionPerDay + " liters, Weight: " + weight + " kg, Breed: " + breed;
        }
    }
}
