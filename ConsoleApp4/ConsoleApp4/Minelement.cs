using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    class Minelement
    {
        public void Arrmin()
        { 
            int[] arr = { 5, 7, 9,1 };
            int min = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if(min>arr[i])
                {
                    min = arr[i];
                }

            }
            int index = Array.IndexOf(arr, min);
            Console.WriteLine(min);
            Console.WriteLine(index);
        }
    }
}
