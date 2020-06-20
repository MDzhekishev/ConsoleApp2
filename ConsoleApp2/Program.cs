using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            sbyte tempSummer = 20;
            Console.WriteLine
                ($"Temperature on Mars on a summer day :\n{tempSummer} С°\n");

            
            short tempWinter = -125;
            Console.WriteLine
                ($"Temperature on Mars on a winter night : \n{tempWinter} С°\n");

           
            ulong cigarette = 10_602_163_273;
            Console.WriteLine
               ($"Cigarettes smoked today : \n{cigarette} pieces \n");

            
            float imf = 3.3f;
            Console.WriteLine
                ($"Before the COVID-19 Pandemic, " +
                $"the IMF forecasts global economic growth by \n{imf} % this year\n");

            
            decimal rurBuy = 1.0710m;
            decimal rurSell = 1.0830m;
                Console.WriteLine($"Ruble to som exchange rate 20.06.2020 : " +
                    $"\nBuy  {rurBuy} \nSell {rurSell} \n");

            
            char respect = 'f';
            Console.WriteLine($"Press \'{respect}\' to pay respect \n");

            
            String rich = "Jeff Bezos";
            ulong jeffcash = 158_000_000_000;
            Console.WriteLine($"The richest man in the world 2020 is : " +
                $"\n{rich} \nfortune {jeffcash} USD\n");



        }
    }
}
