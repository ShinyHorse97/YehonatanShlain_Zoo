using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YehonatanShlain_Zoo
{
    internal class Parrot : Bird
    {
        private string Color;
        public Parrot(string color)
            : base(2, true, 100)
        {
            this.Color = color;
        }
        public string GetColor() { return Color; }
        public void SetColor(string color) { Color = color; }
        public override string ToString()
        {
            return "Parrot: " + base.ToString() + ", Color: " + Color;
        }
    }
}
