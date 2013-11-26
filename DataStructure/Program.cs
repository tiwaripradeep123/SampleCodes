using DataStructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    class DataStructure
    {
        static void Main(string[] args)
        {

            StringOperations operations = new StringOperations();
            string input = "This is string to reverse";

            Console.WriteLine(operations.ReverseAStringUsingRecursion(input, input.Length));
            Console.WriteLine(operations.ReverseAStringUsingStack(input));

            Console.WriteLine(operations.FindIFStringHasUniqueChars("a"));
            Console.WriteLine(operations.FindIFStringHasUniqueChars("aA"));
            Console.WriteLine(operations.FindIFStringHasUniqueChars("alah"));
            Console.WriteLine(operations.FindIFStringHasUniqueChars("thisunqe"));

            Console.WriteLine(operations.ReverseANumber(123456));

            Console.WriteLine(operations.AreAnagram("pradeep", "deeppra"));
            Console.WriteLine(operations.AreAnagram("and", "ann"));

            operations.FindUniqueChars(string.Empty);
            operations.FindUniqueChars(null);
            Console.WriteLine(operations.FindUniqueChars("abcccdeffghijklmnopppppppppabcccdeffghijklmnopppppppppabcqrstuvwxyzccdeffghijklmnopppppppppabcccdeffghijklmnopppppppppabcccdeffghijklmnoppppppppp"));
            Console.WriteLine(operations.FindUniqueChars());


            // Matrix problems 

            Matrix matrix = new Matrix();
            var chars = matrix.StoreAToZCharsIntoSquareMatrix();

            char[] chars1 = new char[100];
            char A = 'A';
            
            for (int i = 0; i < 26; i++)
            {
                chars1[i] = A++;
            }

            Console.WriteLine(new string(chars1));

            Console.ReadLine();
        }
    }
}


