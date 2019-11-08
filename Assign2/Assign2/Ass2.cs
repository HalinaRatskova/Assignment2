using System;
using System.Collections.Generic;
using System.Text;

namespace Assign2
{
    class Ass2
    {
        public void frequencyArray(int[] myArray)
        {
            int[] frequency = new int[myArray.Length];

            for (int i = 0; i < myArray.Length; i++)
            {
                int counter = 1;

                for (int j = i + 1; j < myArray.Length; j++)
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
