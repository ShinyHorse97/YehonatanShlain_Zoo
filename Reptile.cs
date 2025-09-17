using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace YehonatanShlain_Zoo
{
    internal class Reptile : Animal
    {
        private double tailLength;
        private string Temperature;
        public Reptile(double tailLength, bool isVenomous, string temperature)
            : base("unknown reptile", "unknown", 0, false, new Date(1, 1, 2000))
        {
            this.tailLength = tailLength;
            Temperature = temperature;
        }
        public double GetTailLength() { return tailLength; }
        public string GetTemperature() { return Temperature; }
        public void SetTailLength(double tailLength) { this.tailLength = tailLength; }
        public void SetTemperature(string temperature) { Temperature = temperature; }
        public override string ToString()
        {
            return base.ToString() + ", Tail length: " + "Is poisonous: " + ", Temperature: " + Temperature;
        }
    }
}
