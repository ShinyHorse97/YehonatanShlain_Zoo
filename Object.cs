using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YehonatanShlain_Zoo
{
    internal class Object
    {
        private string Name;
        private int Value;
        private int Size;
        private string location;
        public Object(string name, int Value, int Size, string location)
        {
            this.Name = name;
            this.Value = Value;
            this.Size = Size;
            this.location = location;
        }
        public string GetName() { return Name; }
        public int GetValue() { return Value; }
        public int GetSize() { return Size; }
        public string GetLocation() { return location; }
        public void SetName(string name) { Name = name; }
        public void SetValue(int value) { Value = value; }
        public void SetSize(int size) { Size = size; }
        public void SetLocation(string location) { this.location = location; }

    }
}
