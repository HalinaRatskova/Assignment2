using System;

namespace Assign2
{
    class Program
    {
        static void Main(string[] args)
        {
            Ass2 frequency = new Ass2();
            int[] myArray = new int[] { 1, 2, 3, 1, 1,3,3,3,5 };
            frequency.frequencyArray(myArray);

        }
    }
}


