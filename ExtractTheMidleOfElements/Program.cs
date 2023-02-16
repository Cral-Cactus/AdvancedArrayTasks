using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the numbers (separated by spaces): ");
        string[] input = Console.ReadLine().Split();
        int[] numbers = Array.ConvertAll(input, int.Parse);

        int[] middle = GetMiddle(numbers);

        Console.WriteLine("{ " + string.Join(" ", middle) + " }");
    }

    static int[] GetMiddle(int[] numbers)
    {
        int n = numbers.Length;

        if (n == 1)
        {
            return new int[] { numbers[0] };
        }
        else if (n % 2 == 0)
        {
            return new int[] { numbers[n / 2 - 1], numbers[n / 2] };
        }
        else
        {
            return new int[] { numbers[n / 2 - 1], numbers[n / 2], numbers[n / 2 + 1] };
        }
    }
}