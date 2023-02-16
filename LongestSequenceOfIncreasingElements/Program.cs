using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the numbers (separated by spaces): ");
        string[] input = Console.ReadLine().Split();
        int[] numbers = Array.ConvertAll(input, int.Parse);

        int start = 0;
        int len = 1;
        int bestStart = 0;
        int bestLen = 1;

        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] > numbers[i - 1])
            {
                len++;

                if (len > bestLen)
                {
                    bestStart = start;
                    bestLen = len;
                }
            }
            else
            {
                start = i;
                len = 1;
            }
        }

        int[] longestSequence = new int[bestLen];
        Array.Copy(numbers, bestStart, longestSequence, 0, bestLen);

        Console.Write($"Longest increasing sequence: {string.Join(" ", longestSequence)}");
    }
}