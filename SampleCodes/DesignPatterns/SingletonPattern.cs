using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCode
{
    public class SingletonPattern
    {
        public static SingletonPattern SingletonObject;
        private static object lockObject = new object();


        /// <summary>
        /// Static constructor to initialize using double lock.
        /// </summary>
        static SingletonPattern()
        {
            if (SingletonObject == null)
            {
                lock (lockObject)
                {
                    if (SingletonObject == null)
                    {
                        SingletonObject = new SingletonPattern();
                    }
                }
            }
        }

        /// <summary>
        /// Make it private so that it can`t be called.
        /// </summary>
        private SingletonPattern()
        {
        
        }
    }
}
