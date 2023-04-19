using System;

namespace Classwork_19._04._23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] mas = new double[12];
            Random r =new Random();
            //float S = 0;
            for (int i = 1; i < mas.Length; i++)
            {
                mas[i] = r.Next(10, 100);
                Console.Write($"{mas[i]:F2} + ");
                //S += mas[i];
            }
            //Console.WriteLine();
            //Console.WriteLine("S="+S);
            //Console.WriteLine($"S = {S:F2}");
            //Console.WriteLine("S={0}," ,S);
            //int[] score = new int[10];
            //Random r = new Random();
            //int summ = 0;
            //for (int i = 0; i < score.Length; i++)
            //{
            //    score[i] = r.Next(1, 10);
            //    Console.WriteLine(score[i]);
            //    summ = summ + score[i];
            //}
            //Console.WriteLine($"Сумма = {summ}");
            //if (summ > 40)
            //{
            //    Console.WriteLine("Прошёл, сумма баллов выше 40");
            //}
            //int a = 5, b = 2;
            //int c = a;
            //a = b;
            //b = c;
            double temp = mas[2];
            mas[2] = mas[5];
            mas[5] = temp;
            foreach (double i in mas) Console.WriteLine(i);
            Console.WriteLine();
        }
    }
}