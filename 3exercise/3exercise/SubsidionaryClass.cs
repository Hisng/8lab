using System;
using System.Collections.Generic;
using System.Text;

namespace _3exercise
{
    class SubsidionaryClass : BaseClass
    {
        private string[] stringarray = new string[100];



        public string this[int index]
        {
            get
            {
                if (0 <= index && index < stringarray.Length)
                {
                    return stringarray[index];
                }
                else
                {
                    return null;
                }
            }
            set
            {
                if (0 <= index && index < stringarray.Length)
                {
                    stringarray[index] = value;
                }
            }
        }


        public int[] Arrays
        {
            get
            {
                return new int[] { stringarray.Length, Intarray };
            }
        }
    }
}
