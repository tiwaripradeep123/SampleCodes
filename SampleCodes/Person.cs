using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCode
{
    [DebuggerDisplay("Name={0}, Age = {1}", Name = "Name")]
    class Person
    {
        public int Age { get; set; }
        public string Name { get; set; }

        public static bool operator ==(Person first, Person other)
        {
            return first.Age == other.Age && first.Name == other.Name;
        }

        public static bool operator !=(Person first, Person other)
        {
            return first.Age != other.Age || first.Name != other.Name;
        }

        public override bool Equals(object obj)
        {
            return this == (obj as Person);
        }

        public override string ToString()
        {
            return string.Format("Name - {0}, age - {1}", this.Name, this.Age);
        }
    }
}
