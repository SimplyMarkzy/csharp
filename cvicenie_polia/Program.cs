using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

namespace cvicenie_polia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*for (int i = 0; i < numbers.Length; i++)
            int[] numbers = new int[6];
            numbers[1] = 15;
            numbers[2] = 2;
            numbers[0] = 1;
            numbers[3] = 3;
            numbers[4] = 4;
            numbers[5] = 20;
            int sum = 0;
            {
                sum += numbers[i];  
            }
            Console.WriteLine(sum);
             foreach (var item  in numbers)
            {
                sum += item;
            }
             Console.WriteLine(sum);
            */
            //cez jeden cyklus naplnit pole hodnotami pomocou write line a nasledne sctitat vsetky hodnoty #

            
            int sum = 0;

            while (true)
            {
                Console.WriteLine("how many numbers do you want");
                int number1 = int.Parse(Console.ReadLine());
                int[] number = new int[number1];
                for (int i = 0; i < number1; i++)
                {
                    Console.WriteLine("zadaj cisla");
                    number[i] = int.Parse(Console.ReadLine());
                }
                foreach (int i in number)
                {
                    sum += i;
                }


                Console.WriteLine(sum);
                string input = Console.ReadLine();
                if (input == "exit")
                break;
            }



        }
    }
}
