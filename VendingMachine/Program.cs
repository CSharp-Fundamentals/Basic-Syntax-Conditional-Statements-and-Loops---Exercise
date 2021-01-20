using System;

namespace VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            string insert = Console.ReadLine();
            double sum = 0;

            while (insert != "Start")
            {
                double coin = double.Parse(insert);
                if (coin == 0.1 || coin == 0.2 || coin == 0.5 || coin == 1 || coin == 2)
                {
                    sum += coin;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {coin}");
                }
                insert = Console.ReadLine();
            }

            insert = Console.ReadLine();

            while (insert != "End")
            {
                if (insert == "Nuts")
                {
                    if (sum >= 2.0)
                    {
                        Console.WriteLine("Purchased nuts");
                        sum -= 2.0;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (insert == "Water")
                {
                    if (sum >= 0.7)
                    {
                        Console.WriteLine("Purchased water");
                        sum -= 0.7;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (insert == "Crisps")
                {
                    if (sum >= 1.5)
                    {
                        Console.WriteLine("Purchased crisps");
                        sum -= 1.5;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (insert == "Soda")
                {
                    if (sum >= 0.8)
                    {

                        Console.WriteLine("Purchased soda");
                        sum -= 0.8;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (insert == "Coke")
                {
                    if (sum >= 1.0)
                    {

                        Console.WriteLine("Purchased coke");
                        sum -= 1.0;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid product");
                }
                insert = Console.ReadLine();
            }
            Console.WriteLine($"Change: {sum:F2}");
        }
    }
}
