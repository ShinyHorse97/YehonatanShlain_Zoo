using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YehonatanShlain_Zoo
{
    internal class Animal
    {
       private string name;
       private string gender;
       private double calories;
       private bool predator;
       private Date dateOfBirth;

        public Animal(string name, string gender, double calories, bool predator, Date dateOfBirth)
        {
            this.name = name;
            this.gender = gender;
            this.calories = calories;
            this.predator = predator;
            this.dateOfBirth = dateOfBirth;
        }
        public string GetName() { return name; }
        public string GetGender() { return gender; } 
        public double GetCalories() { return calories; }
        public bool IsPredator() { return predator; }
        public Date GetDateOfBirth() { return dateOfBirth; }
        public void SetName(string name) { this.name = name; }
        public void SetCalories(double calories) { this.calories = calories; }
        public virtual double Eat() { return calories * 3; }
        public override string ToString()
        {
            return "name: " + name + ", gender: " + gender + ", Cal per meal: " + calories + ", predator: " + predator + ", date of birth: " + dateOfBirth.ToString() ;
        }
    }
}
