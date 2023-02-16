using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.Write("Input numbers as letters separated by space: ");
        string[] arr = Console.ReadLine().Split();
        Console.Write("Input number of commands you want to use: ");
        sbyte n = sbyte.Parse(Console.ReadLine());

        for (sbyte i = 0; i < n; i++)
        {
            Console.Write($"Command {i + 1}: ");
            string[] command = Console.ReadLine().ToLower().Split();

            if (command[0] == "reverse")
            {
                ReverseArray(arr);
            }
            else if (command[0] == "distinct")
            {
                arr = GetDistinctArray(arr);
            }
            else if (command[0] == "replace")
            {
                byte index = byte.Parse(command[1]);
                string replacement = command[2];
                
                ReplaceElement(arr, index, replacement);
            }
        }

        Console.WriteLine($"Output: {string.Join(", ", arr)}");
    }

    static void ReverseArray(string[] arr)
    {
        Array.Reverse(arr);
    }

    static string[] GetDistinctArray(string[] arr)
    {
        return arr.Distinct().ToArray();
    }

    static void ReplaceElement(string[] arr, byte index, string replacement)
    {
        arr[index] = replacement;
    }
}