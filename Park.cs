
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YehonatanShlain_Zoo
{
    internal class Park
    {
        private Animal[] animals;
        private int count;
        public Park()
        {
            animals = new Animal[100];
            count = 0;
        }
        public bool AddAnimal(Animal a)
        {
            if (count < animals.Length)
            {
                animals[count] = a;
                count++;
                return true;
            }
            else
            {
                Console.WriteLine("Park is full, cannot add more animals.");
                return false;
            }
        }
        public int GetCalSum()
        {
            int sum = 0;
            for (int i = 0; i < count; i++)
            {
                sum += (int)animals[i].GetCalories();
            }
            return sum;
        }
    }
}
