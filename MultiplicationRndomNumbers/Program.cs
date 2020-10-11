using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultiplicationRndomNumbers
{
    class Program
    {
      static  int i = 0;
        static int[] nums = new int[] { 1, 9 ,2,8,3,7,4,6,5};
        static int n;
        static void Multiplication()
        {
            if (i<nums.Length)
            {
                Thread.Sleep(500);
                Console.WriteLine(nums[i]+" " +"X"+" "+ +n+ " = " +nums[i]*n);
                i++;
                Multiplication();
            }
            return;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Multiplier");
            n = Convert.ToInt32(Console.ReadLine());
            Multiplication();
            Console.ReadKey();
        }
    }
}
