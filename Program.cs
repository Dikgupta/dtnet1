using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleDimensionArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArr = new int[5];

            Console.Write("Enter Array Element : ");

            for (int i = 0; i < intArr.Length; i++)
            {
                intArr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Array Elements Are : ");
            for (int i = 0; i < intArr.Length; i++)
            {
                Console.Write(intArr[i] + "\t");
            }
            Console.WriteLine();

            Array.Sort(intArr);

            Console.WriteLine("Sorted Array is : ");
            for (int i = 0; i < intArr.Length; i++)
            {
                Console.Write(intArr[i] + "\t");
            }
            Console.ReadKey();
        }
    }
}
