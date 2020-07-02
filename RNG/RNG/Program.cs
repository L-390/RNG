using System;

namespace RNG
{
    class Program
    {
        static void Main(string[] args)
        {
            int loop = 1;
            int Input1 = 0;
            int Input2 = 0;
            string Inputend;

            while(loop == 1)
            {
                int RN = 0;

                Console.WriteLine("Write smaller number.");
                Input1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Write bigger number.");
                Input2 = Convert.ToInt32(Console.ReadLine());

                while(Input2 <= Input1)
                {
                    Console.WriteLine("The second number has to be smaller than the first. Please pick a new number");
                    Input2 = Convert.ToInt32(Console.ReadLine());
                }

                Random rnd = new Random();
                RN = rnd.Next(Input1, Input2);
                Console.WriteLine(RN);
                Console.WriteLine("");

                Console.WriteLine("Another number? Yes or No?");
                Inputend = Console.ReadLine();
                Console.WriteLine("");

                if(Inputend == "No")
                {
                    loop = 0;
                }
            }
        }
    }
}
