using System;
using System.Linq;

namespace WarehouseUpgraded
{
    internal class Program
    {
        static void Main()
        {
            string[] products = Console.ReadLine().Split();
            long[] quantities = Console.ReadLine().Split().Select(long.Parse).ToArray();
            double[] prices = Console.ReadLine().Split().Select(double.Parse).ToArray();

            while (true)
            {
                string[] input = Console.ReadLine().Split();
                if (input[0] == "done")
                {
                    break;
                }

                string productName = input[0];
                long productQuantity = long.Parse(input[1]);

                int productIndex = Array.IndexOf(products, productName);

                if (productIndex != -1 && productQuantity <= quantities[productIndex])
                {
                    quantities[productIndex] -= productQuantity;
                    double totalPrice = productQuantity * prices[productIndex];
                    
                    Console.WriteLine($"{productName} x {productQuantity} costs: {totalPrice:F2}!");
                }
                else if (productIndex != -1 && productQuantity > quantities[productIndex])
                {
                    Console.WriteLine($"We do not have enough {productName} ({quantities[productIndex]} left)!");
                }
                else
                {
                    Console.WriteLine($"We do not sell {productName}!");
                }
            }
        }
    }
}