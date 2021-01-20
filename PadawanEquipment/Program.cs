using System;

namespace PadawanEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double lightsabers = double.Parse(Console.ReadLine());
            double robes = double.Parse(Console.ReadLine());
            double belts = double.Parse(Console.ReadLine());

            double tenPercent = Math.Ceiling(students * 0.10);
            int freeBelt = students / 6;

            double lightsabersPrice = (lightsabers * (students + tenPercent));
            double robesPrice = robes * students;
            double beltsPrice = belts * (students-freeBelt);

            double neededMoney = lightsabersPrice + robesPrice + beltsPrice;

            if (money-neededMoney>=0)
            {
                Console.WriteLine($"The money is enough - it would cost {neededMoney:f2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {Math.Abs(money-neededMoney):f2}lv more.");
            }

        }
    }
}
