using System;

namespace _1exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseClass baseClass = new BaseClass();
          
            baseClass[0] = "Hello";
            baseClass[1] = "World";

            Console.WriteLine(baseClass[0] + " " + baseClass[1]);
        }
    }
}
