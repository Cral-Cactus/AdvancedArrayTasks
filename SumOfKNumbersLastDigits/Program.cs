using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the number of elements (n): ");
        int n = int.Parse(Console.ReadLine());
        
        Console.Write("Enter the number of previous elements to sum (k): ");
        int k = int.Parse(Console.ReadLine());
        
        int[] seq = new int[n];
        seq[0] = 1;
        
        for (int i = 1; i < n; i++)
        {
            int sum = 0;
            for (int j = i - 1; j >= Math.Max(0, i - k); j--)
            {
                sum += seq[j];
            }
            seq[i] = sum;
        }
        
        for (int i = 0; i < n; i++)
        {
            Console.Write($"{seq[i]}");
            if (i < n - 1)
            {
                Console.Write(" + ");
            }
        }
        Console.Write($" = {seq[n - 1]}");
    }
}