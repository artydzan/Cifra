namespace Classwork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //{
            //    int[] mass = new int[12];
            //    Random r = new Random();
            //    int min = mass[0];
            //    for (int i = 0; i < mass.Length; i++)
            //    {
            //        mass[i] = r.Next(10, 100);
            //        Console.Write($"{mass[i]}");
            //        if (mass[i] < min) min = mass[i];
            //    }
            //    Console.WriteLine();
            //    int index = -1;
            //    for (int i = 0; i < mass.Length; i++)
            //    {
            //        if (mass[i] == min) index = i;
            //    }
            //    int temp = mass[0];
            //    mass[0] = mass[index];
            //    mass[index] = temp;
            //    foreach (double i in mass)
            //        Console.WriteLine(i+"");
            //    Console.WriteLine();
            Console.WriteLine("Введите размер массива");
            int n = int.Parse(args[0]);
            int[] mas = new int[n];
            Random r = new Random();
            int count = 0;
            while(count<n)
            {
                int a=r.Next(-10,11);
                bool b = false;
                for (int i = 0; i<=count; i++)
                {
                    if (mas[i] == a) b = true;
                    if(b == false)
                    {
                        mas[count] = a;
                        count++;
                    }   
                }
            }
        }
    }
}