using System;

namespace _3exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            SubsidionaryClass subclass = new SubsidionaryClass();
            subclass[0] = "Hello";
            Console.WriteLine(subclass[0]);

            for (int i = 0; i < subclass.Arrays.Length; i++)
            {
                Console.WriteLine(subclass.Arrays[i]);
            }
        }
    }
}
