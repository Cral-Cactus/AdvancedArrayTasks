using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the numbers (separated by spaces): ");
        string[] input = Console.ReadLine().Split();
        int[] targets = Array.ConvertAll(input, int.Parse);

        int start = 0;
        int len = 1;
        int bestStart = 0;
        int bestLen = 1;

        for (int i = 1; i < targets.Length; i++)
        {
            if (targets[i] == targets[i - 1])
            {
                len++;
            }
            else
            {
                if (len > bestLen)
                {
                    bestStart = start;
                    bestLen = len;
                }

                start = i;
                len = 1;
            }
        }

        if (len > bestLen)
        {
            bestStart = start;
            bestLen = len;
        }

        Console.Write("Longest sequence of identical elements: ");
        for (int i = bestStart; i < bestStart + bestLen; i++)
        {
            Console.Write($"{targets[i]} ");
        }
    }
}