using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buoi1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bài Mẫu của Thầy
            //Console.Title = "Selection Sort";
            //var numbers = new[] { 10, 3, 1, 7, 9, 2, 0 };

            //for (int i = 0; i < numbers.Length - 1; i++)
            //{
            //    int m = i;
            //    int maxValue = numbers[i];

            //    for (int j = i + 1; j < numbers.Length; j++)
            //    {
            //        if (numbers[j].CompareTo(maxValue) > 0)
            //        {
            //            m = j;
            //            maxValue = numbers[j];
            //        }
            //    }

            //    int temp = numbers[i];
            //    numbers[i] = numbers[m];
            //    numbers[m] = temp;
            //}
            //Console.ReadKey();

            //Tính tổng của các phần tử trong mảng a có n số nguyên
            int[] a = { 1, 2, 3, 4, 5 };
            int sum = TinhTongMang(a);
            Console.WriteLine("Tổng các phần tử trong mảng a là: " + sum);
            Console.ReadLine();


        }

        public static int TinhTongMang(int[] arr)
        {
            int sum = 0;
            foreach (int number in arr)
            {
                sum += number;
            }
            return sum;
        }
    }
}
