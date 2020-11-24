using System;
using System.Collections.Generic;
using System.Text;

namespace _3exercise
{
    class BaseClass
    {
        private int[] intarray = new int[100];


        public int Intarray
        {
            get
            {
                return intarray.Length;
            }
        }  


        public int this[int index]
        {
            get
            {
                if (0 <= index && index < intarray.Length)
                {
                    return intarray[index];
                }
                else 
                {
                    return 0;
                }
            }
            set
            {
                if (0 <= index && index < intarray.Length)
                {
                    intarray[index] = value;
                }
            }
        }

    }
}
