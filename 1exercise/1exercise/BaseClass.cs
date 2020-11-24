using System;
using System.Collections.Generic;
using System.Text;

namespace _1exercise
{
    class BaseClass
    {
        private string x;
        private string y;


        public string this[int index]
        {
            get
            {
                if (index == 0)
                {
                    return x;
                }
                else if (index == 1)
                {
                    return y;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                if (index == 0)
                {
                    x = value;
                }
                else if (index == 1)
                {
                    y = value;
                }
            }
        }
    }
}