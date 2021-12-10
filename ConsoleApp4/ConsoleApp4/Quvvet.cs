using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    class Quvvet
    {
        public void İkininquvveti(int num)
        {
            bool result = false;
            for (int i = 1; i < num; i*=2)
            {
                if(num==2*i)
                {
                    result = true;
                }
                else
                {
                    result = false;
                }
            }
            if(result)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
