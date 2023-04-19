Console.WriteLine("Введте размер массива:");
int n = int.Parse(Console.ReadLine());
int[] mas = new int[n];
Random r = new Random();
int index = -1;
bool b = false;
for (int i = 0; i < n; i++)
{
    mas[i] = r.Next(-10, 11);
    Console.WriteLine(mas[i] + " ");
    if (b !=true && mas[i]<0)
    {
        b = true;
        index = i;
    }
}
Console.WriteLine();
Console.WriteLine(index);
Console.WriteLine("Введите число");
int m = int.Parse(Console.ReadLine());
int[] result = new int[n + 1];
b = false;
for (int i = 0; i < result.Length; i++)
{
    if (i == index)
    {
        result[i] = mas[i];
        result[++i] = m;
        b = true;
    }
    else
    {
        result[i] = mas[i - 1];
    }
}
foreach (int i in result) Console.WriteLine(i+" ");
Console.WriteLine();
