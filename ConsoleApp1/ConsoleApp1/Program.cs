namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////сортировка массива
            //int[] mas = new int[10];
            //Random Random = new Random();
            //for (int i = 0; i < mas.Length; i++)
            //{
            //    mas[i] = Random.Next(10, 100);
            //    //Console.Write(mas[i]+" ");
            //}
            ////for (int i = 0; i < mas.Length; i++)
            ////{
            ////    for(int j=i+1;j<mas.Length - 1; j++)
            ////    {
            ////        if (mas[i] > mas[j])
            ////        {
            ////            int temp = mas[j];
            ////            mas[i] = mas[j];
            ////            mas[j] = temp;
            ////        }
            ////    }
            ////}
            ////foreach (int item in mas)
            ////{
            ////    Console.WriteLine(item+" ");
            ////}
            ////Console.WriteLine();
            //Array.Sort(mas);
            //foreach (int item in mas)
            //{
            //    Console.Write(item + " ");
            //}
            //Console.WriteLine();
            //Console.WriteLine(Array.BinarySearch(mas, 56));
            //int[] mas2 = new int[10];
            //Array.ConstrainedCopy(mas, 2, mas2, 4, 4);
            //Array.Copy(mas, mas2, 6);
            //foreach (int item in mas2)
            //{
            //    Console.Write(item + " ");
            //}
            //Console.WriteLine(Array.IndexOf(mas, 45));
            //int[] height = new int[15];
            //Random Random = new Random();
            //for (int i = 0; i < height.Length; i++)
            //{
            //    height[i] = Random.Next(160, 200);
            //}
            //Array.Sort(height);
            //Array.Reverse(height);
            //Console.Write("Введите рост нового ученика:");
            //int student_height = int.Parse(Console.ReadLine());
            //int[] new_height = new int[16];
            //Array.Copy(height, new_height, height.Length);
            //Array.Fill(new_height, student_height, 15, 1);
            //Array.Sort(new_height);
            //foreach (int item in new_height)
            //{
            //    Console.WriteLine(item + " ");
            //}
            int[,] mas = new int[25, 36];
            Random rand = new Random();
            //int[] newMas = new int[36];
            int max = int.MinValue;
            int index = -1;
            //for (int i = 0; i < mas.GetLength(0); i++)
            //{
            //    for (int j = 0; j < mas.GetLength(1); j++)
            //    {
            //        mas[i, j] = rand.Next(2);
            //        Console.Write(mas[i, j]+" ");
            //        newMas[i] = mas[i, j];
            //    }
            //    int sum = newMas.Sum();
            //    if (sum > max)
            //    {
            //        max = sum;
            //        index = i;
            //    }
            //    Console.WriteLine();
            //}
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                int s = 0;
                for (int j=0; j < mas.GetLength(1); j++)
                {
                    mas[i, j] = rand.Next(2);
                    Console.Write(mas[i, j] + " ");
                    s += mas[i, j];
                }
                if (s > max)
                {
                    max = s;
                    index = i;
                }
            }
            Console.WriteLine();
            Console.WriteLine(max);
        }
    }
}