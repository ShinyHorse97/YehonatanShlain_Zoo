using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YehonatanShlain_Zoo
{
    internal class Bird : Animal
    {
        private double wingSpan;
        private bool canFly;
        private double FlightAltitude;
        public Bird(double wingSpan, bool canFly, double flightAltitude)
            : base("unknown bird", "unknown", 0, false, new Date(1, 1, 2000))
        {
            this.wingSpan = wingSpan;
            this.canFly = canFly;
            this.FlightAltitude = flightAltitude;
        }
        public double GetWingSpan() { return wingSpan; }
        public bool CanFly() { return canFly; }
        public double GetFlightAltitude() { return FlightAltitude; }
        public void SetWingSpan(double wingSpan) { this.wingSpan = wingSpan; }
        public void SetCanFly(bool canFly) { this.canFly = canFly; }
        public void SetFlightAltitude(double flightAltitude) { FlightAltitude = flightAltitude; }
        public string Sing()
        {
            return "Chirp chirp";
        }
        public void Dance()
        {
            Console.WriteLine("The bird is dancing");
        }
        public override double Eat() { return base.Eat() * 0.1; }
        public override string ToString()
        {
            return base.ToString() + ", Wing span: " + wingSpan + ", can fly: " + canFly + ", Flight altitude: " + FlightAltitude;
        }
    }
}
