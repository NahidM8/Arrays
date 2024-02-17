using System;
using System.Linq;
internal class Program
    {
        static void Main(string[] args)
        {
        //task1
        int[] numbers = { 1, 12, 3, 24, 4 ,97 };
        int sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }
        Console.WriteLine(sum);


        //task2
        int[] numbers2 = { 1, 12,23,55 };
        Console.WriteLine(numbers2.Max(x => x));



        //task3
        int[] numbers3 = { 1, 12, 23, 34, 444, };
        Console.WriteLine(numbers3[0] + numbers3[numbers3.Length-1]);



        //other_task
        //int num=Convert.ToInt32(Console.ReadLine());
        //int count = 0;
        //for (int i = 1; i < num; i++)
        //{
        //    if (num%i==0)
        //    {
        //        count++;
        //    }
        //}
        //if (count>=2)
        //{
        //    Console.WriteLine("murekkebdir");
        //}
        //else
        //{
        //    Console.WriteLine("sadedir");
        //}

        //other_task1
        //int num1 =Convert.ToInt32(Console.ReadLine());
        //int product = 1;
        //for (int i = 1;i <= num1;i++)
        //{
        //    product*= i;
        //}
        //Console.WriteLine(product);

        //other_task2
        //int[] ints = { 1, 12, 5, 11, 5, 5 };
        //int count = 0;
        //for (int i = 0;i < ints.Length;i++)
        //{
        //    if (ints[i] == 5)
        //    {
        //        count++;
        //    }
        //}
        //Console.WriteLine(count);


        //other_task3
        //int[] numbers4 = { 23, 65, 22, 29, 41, 57 };
        //int count = 0;
        //foreach (int item in numbers4)
        //{
        //    bool isPrime = true;
        //    for (int i = 2;i < item/2;i++)
        //    {
        //        if (item % i == 0)
        //        {
        //            isPrime = false;
        //            break;
        //        }
        //    }

        //    if (isPrime)
        //    {
        //        count++;
        //    }
        //}
        //Console.WriteLine(count);

        //int[] ints = { 1, 12, 43, 41, 23, 6 };
        //int count = 0;
        //foreach (int item in ints)
        //{
        //    bool isPrime=true;
        //    for (int i = 2; i < item / 2; i++)
        //    {
        //        if (item%i==0)
        //        {
        //            isPrime = false;
        //            break;
        //        }
        //    }

        //    if (isPrime)
        //    {
        //        count++;
        //    }
        }
    }

