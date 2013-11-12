using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


namespace SampleCode
{
    class Persons : IEnumerable<Person>, ICrudOperations<Person>
    {
        Person[] persons = new Person[100];
        int index = 0;


        public Person this[int index]
        {
            get {
                return persons[index];
            }
        }
              
        public void Add(Person t)
        {
            persons[index++] = t;
        }

        public void Update(Person t)
        {
            
        }

        public void Delete(Person t)
        {
             
        }

        public IEnumerator<Person> GetEnumerator()
        {
            int i = 0;
            while (i < index)
            {
                yield return persons[i];
                i++;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    

    


   public interface ICrudOperations<T>
    {
        void Add(T t);
        void Update(T t);
        void Delete(T t); 
    }
}
