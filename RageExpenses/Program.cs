using System;

namespace RageExpenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int lost = int.Parse(Console.ReadLine());
            double headset = double.Parse(Console.ReadLine());
            double mouse = double.Parse(Console.ReadLine());
            double keyboard = double.Parse(Console.ReadLine());
            double display = double.Parse(Console.ReadLine());

            int trashHeadset = 0;
            int trashMouse = 0;
            int trashKeyboard = 0;
            int trashDisplay = 0;

            for (int i = 1; i <= lost; i++)
            {
                if (i%2==0)
                {
                    trashHeadset++;
                }
                if (i%3==0)
                {
                    trashMouse++;
                }
                if (i%6==0)
                {
                    trashKeyboard++;
                }
                if (i%12==0)
                {
                    trashDisplay++;
                }
            }

            double sum = (trashHeadset * headset) +
                (trashMouse * mouse) +
                (trashKeyboard * keyboard) +
                (trashDisplay*display);

            Console.WriteLine($"Rage expenses: {sum:f2} lv.");
        }
    }
}
