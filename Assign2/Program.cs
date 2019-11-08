using System;

namespace Assign2
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] myArray = new int[] { 1, 2, 3, 1, 1,3,3,3,5 };
            int[] frequency = new int[myArray.Length];

            for (int i = 0; i < myArray.Length; i++)
            {
                int counter = 1;

                for (int j =i+1; j < myArray.Length; j++)
                {
                    if (myArray[i] == myArray[j])
                    {
                        counter++;
                        frequency[j] = -1;
                    }
                }
                if (frequency[i] != -1)
                {
                    frequency[i] = counter;
                }
            }

            for (int k = 0; k < frequency.Length; k++)
            {
                if (frequency[k] != -1)
                    Console.WriteLine("Array element   " + myArray[k] + "    |    " + "Frequency " + frequency[k]);
            }
             Console.ReadLine();
        }
    }
}


