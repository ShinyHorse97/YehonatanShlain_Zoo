using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YehonatanShlain_Zoo
{
    internal class Person
    {
        private string Name;
        private int ID;
        private Date BirthDate;
        public Person(string name, int id, Date birthDate)
        {
            Name = name;
            ID = id;
            BirthDate = birthDate;
        }
        public string GetName() { return Name; }
        public int GetID() { return ID; }
        public Date GetBirthDate() { return BirthDate; }
        public void SetName(string name) { Name = name; }
        public void SetID(int id) { ID = id; }
        public void SetBirthDate(Date birthDate) { BirthDate = birthDate; }
        public override string ToString()
        {
            return "Name: " + Name + ", ID: " + ID + ", Birth date: " + BirthDate;
        }
    }
}
