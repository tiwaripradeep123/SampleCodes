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
            StackX stack = new StackX();
            Console.Write("  " + stack.Pop() + "  ");
            Console.Write("  " + stack.Pop() + "  ");
            stack.Push(new Node() { Data = 11 });
            stack.Push(new Node() { Data = 12 });
            stack.Push(new Node() { Data = 13 });
            stack.Push(new Node() { Data = 14 });
            stack.Push(new Node() { Data = 15 });
            stack.Push(new Node() { Data = 16 });
            Console.Write("  " + stack.Pop() + "  ");
            Console.Write("  " + stack.Pop() + "  ");
            stack.Push(new Node() { Data = 110 });
            Console.Write("  " + stack.Pop() + "  ");
            Console.Write("  " + stack.Pop() + "  ");
            Console.Write("  " + stack.Pop() + "  ");
            stack.Push(new Node() { Data = 1010 });
            while (!stack.IsEmpty())
            {
                Console.Write("  " + stack.Pop() + "  ");
            }

            Console.ReadLine();
        }
    }
}


