using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    class Matrix
    {

        public char[,] StoreAToZCharsIntoSquareMatrix()
        {
            char ch = 'A';
            char[,] chars = new char[4,7];
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    chars[i, j] = ch++;
                }
            }

            return chars;
        }
    }
}
