using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    class StackX
    {
        Node Top;        
        
        public void Push(Node item)
        {
            if (Top == null)
            {
                Top = item;
            }
            else
            {
                item.Next = Top;
                Top = item;
            }
        }


        public int Pop()
        {
            if (Top == null)
            {
                return -1;
            }
            else
            {
                Node temp = Top;
                Top = Top.Next;
                return temp.Data;
            }
        }

        public bool IsEmpty()
        {
            return Top == null;
        }
    }

    class Node
    {
        public int Data;
        public Node Next;
    }
}
