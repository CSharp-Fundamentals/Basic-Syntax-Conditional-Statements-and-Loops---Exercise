using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string day = Console.ReadLine();

            double ticket = 0;
            double percent = 0;
            double sum = 0;


            if (type == "Students")
            {
                if (count >= 30)
                {
                    percent = 15;
                }
                if (day=="Friday")
                {
                    ticket = 8.45;
                }
                else if (day=="Saturday")
                {
                    ticket = 9.80;
                }
                else if (day=="Sunday")
                {
                    ticket = 10.46;
                }
            }
            if (type == "Business")
            {
                if (count>=100)
                {
                    count -= 10;
                }
                if (day == "Friday")
                {
                    ticket = 10.90;
                }
                else if (day == "Saturday")
                {
                    ticket = 15.60;
                }
                else if (day == "Sunday")
                {
                    ticket = 16;
                }
            }
            if (type == "Regular")
            {
                if (count >= 10 && count<=20)
                {
                    percent = 5;
                }
                if (day == "Friday")
                {
                    ticket = 15;
                }
                else if (day == "Saturday")
                {
                    ticket = 20;
                }
                else if (day == "Sunday")
                {
                    ticket = 22.50;
                }
            }

            sum = ticket * count;

            if (percent != 0)
            {
                sum -= sum * percent/100;
            }
            Console.WriteLine($"Total price: {sum:f2}");
        }
    }
}
