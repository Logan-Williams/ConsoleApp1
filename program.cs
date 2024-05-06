using System;

 class Program
{
    private static void Main()
    {
        int M = 1; // начальное значение M
        int N = 10; // конечное значение N
        
        PrintNumbers(M, N);
    }

    private static void PrintNumbers(int current, int end)
    {
        if (current <= end)
        {
            Console.WriteLine(current);
            PrintNumbers(current + 1, end);
        }
    }
}
