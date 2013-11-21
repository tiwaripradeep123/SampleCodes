using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    class StringOperations
    {



        

        public int ReverseANumber(int number)
        {
            int result = 0;

            while (number > 0)
            {
                result = result * 10 + number % 10;
                number = number / 10;
            }

            return result;
        }



        
        public bool FindIFStringHasUniqueChars(string input)
        {
            bool[] CharFlags = new bool[26];
            int index = -1;

            while (++index < input.Length)
            {
                int position = input[index];

                if (position >= 97) // to accomodate lowercase and upper case stuff.
                {
                    position -= 97;
                }
                else
                {
                    position -= 65;
                }


                if (CharFlags[position]) // finally they will be one of 26 alphabets.
                {
                    return false;
                }
                else
                {
                    CharFlags[position] = true;
                }

            }
            return true;
        }


        public string ReverseTheWordsInAString(string input)
        {
            //Stack<string> strings = new Stack<string>();

            //int index = -1;
            //int last

            //while (++index<)
            //{
                
            //}

            return null;
        }
       
        public string ReverseAStringUsingStack(string input)
        {
            int index = 0;
            Stack<char> Chars = new Stack<char>();

            while (index < input.Length)
            {
                Chars.Push(input[index++]);
            }

            StringBuilder Builder = new StringBuilder();

            while (Chars.Count > 0)
            {
                Builder.Append(Chars.Pop());
            }

            return Builder.ToString();
        }

        public string ReverseAStringUsingRecursion(string input, int length)
        {
            if (length == 1)
            {
                return input[--length].ToString();
            }
            else
            {
                return input[--length] + ReverseAStringUsingRecursion(input, length);
            }
        
        }

        /// <summary>
        /// Find if two strings are anagram
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns></returns>
        internal string AreAnagram(string p1, string p2)
        {
            if (p1 == null || string.IsNullOrWhiteSpace(p1) || p2 == null || string.IsNullOrWhiteSpace(p2) || p1.Length != p2.Length)
            {
                return false.ToString();
            }
            else
            {
                int[] counts = new int[256];

                int index = -1;

                while (++index < p1.Length )
                {
                    counts[p1[index]] += 1;
                }

                while (--index != 0)
                {
                    if (counts[p2[index]] <= 0)
                    {
                        return false.ToString();
                    }
                    else
                    {
                        counts[p2[index]] -= 1;
                    }
                }

                return true.ToString();
            }
        }
    }
}
