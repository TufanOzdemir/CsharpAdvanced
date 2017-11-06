using System;
using System.Collections.Generic;
using System.Text;

namespace Indexers
{
    public class Stack
    {
        private int Index { get; set; }
        private int[] Members { get; set; }

        public Stack()
        {
            Members = new int[50];
            Index = 0;
        }

        public void Add(int number)
        {
            Members[Index] = number;
            Index++;
        }

        public int Pop()
        {
            Index--;
            return Members[Index];
        }

        public int this[int index]
        {
            get
            {
                if(index < 0 || index > 50)
                {
                    return 0;
                }
                else
                {
                    return Members[index];
                }
            }
            set
            {
                if (!(index < 0 || index > 50))
                {
                    Members[index] = value;
                }
            }
        }
    }
}
