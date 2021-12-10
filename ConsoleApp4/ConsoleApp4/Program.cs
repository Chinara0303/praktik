using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            //ikinin quvveti
            //Quvvet num1 = new Quvvet();
            //num1.İkininquvveti(9);

            // task1 10 elementden ibaret arrayin elementlerinin sondan capi
            //int[] arr = { 46, 6, 7, 22, 3, 78, 56, 5, 100, 1 };
            //for (int i = arr.Length-1; i >=0 ; i--)
            //{
            //    Console.WriteLine(arr[i]);
            //}

            //task3 boyukden kiciye
            //int[] arr = new int[4];
            //int[] arr1 = new int[4];
            //int[] arr2 = new int[8];
            //arr2[0] = 3;
            //arr2[1] = 5;
            //arr2[2] = 10;
            //arr2[3] = 8;
            //arr2[4] = 20;
            //arr2[5] = 18;
            //arr2[6] = 81;
            //arr2[7] = 80;
            //Array.Sort(arr2);
            //Array.Reverse(arr2);
            //foreach (int item in arr2)
            //{
            //    Console.WriteLine(item);
            //}

            //task4
            //int[] arr = { 3, 6, 9, 5, 4 };
            //int min = arr[0];
            //int max = arr[0];
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (min > arr[i])
            //    {
            //        min = arr[i];
            //    }
            //    else if (max < arr[i])
            //    {
            //        max = arr[i];
            //    }
            //}
            //Console.WriteLine(min);
            //Console.WriteLine(max);



            // task 5
            //int[] arr1 = { 3, 56, 4, 78, 98, 65, 43, 23, 44, 34, 6 };
            //int[] arr2 = new int[arr1.Length];
            //int[] arr3 = new int[arr1.Length];
            //int i = 0;
            //int j = 0;
            //int z = 0;
            //for ( i = 0; i < arr1.Length; i++)
            //{
            //    if(arr1[i]%2==0)
            //    {
            //        arr2[j] = arr1[i];
            //        j++;
            //    }
            //    else
            //    {
            //        arr3[z] = arr1[i];
            //        z++;
            //    }
            //}
            //for ( i = 0; i < j; i++)
            //{
            //    Console.WriteLine(arr2[i]);
            //}
            //for ( i = 0; i < z; i++)
            //{
            //    Console.WriteLine(arr3[i]);
            //}


            Minelement arr1 = new Minelement();
            arr1.Arrmin();
        }
    }
}
