using System;

public class Program
{
    public static void Main()
    {
        int n = 10; // Example: Find the 10th Fibonacci number
        int result = FindNthFibonacci(n);
        Console.WriteLine($"The {n}th Fibonacci number is: {result}");
    }

    public static int FindNthFibonacci(int n)
    {
        if (n <= 1)
            return n;

        int a = 0, b = 1;

        for (int i = 2; i <= n; i++)
        {
            int temp = a + b;
            a = b;
            b = temp;
        }

        return b;
    }
}
