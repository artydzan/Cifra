namespace NewClasswork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] mas = new int[10, 10];
            Random rand = new Random();
            int[] newMas = new int[10];
            int[] res = new int[10];
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                int maximum = int.MinValue;
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    mas[i, j] = rand.Next(100);
                    Console.Write(mas[i, j] + " ");
                    newMas[i] = mas[i, j];
                }
                Console.WriteLine();
                res[i] = maximum;

            }
            Console.WriteLine();
            foreach (int item in res)
            {
                Console.Write(item + " ");
            }
        }
    }
}