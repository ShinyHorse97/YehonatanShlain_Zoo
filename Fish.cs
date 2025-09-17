using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YehonatanShlain_Zoo
{
    internal class Fish : Animal
    {
        private double WaterDepth;
        private string WaterType;
        private double Length;
        public Fish(double waterDepth, string waterType, double length)
            : base("unknown fish", "unknown", 0, false, new Date(1, 1, 2000))
        {
            this.WaterDepth = waterDepth;
            this.WaterType = waterType;
            this.Length = length;
        }
        public double GetWaterDepth() { return WaterDepth; }
        public string GetWaterType() { return WaterType; }
        public double GetLength() { return Length; }
        public void SetWaterDepth(double waterDepth) { WaterDepth = waterDepth; }
        public void SetWaterType(string waterType) { WaterType = waterType; }
        public void SetLength(double length) { Length = length; }
        public override string ToString()
        {
            return base.ToString() + ", Water depth: " + WaterDepth + ", Water type: " + WaterType + ", Length: " + Length;
        }
    }
}
