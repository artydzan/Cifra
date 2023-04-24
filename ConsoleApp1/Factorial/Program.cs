Console.WriteLine(Factorial(5));
Console.WriteLine(RecFact(5));
long Factorial(int n)
{
    long F = 1;
    for (int i = 1; i <= n; i++) F *= i;
    return F;
}
long RecFact(int n)
{
    if(n == 0 || n == 1) return 1;
    return n * RecFact(n - 1);
}
