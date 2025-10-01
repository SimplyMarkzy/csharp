using System.Reflection.Metadata.Ecma335;

namespace cvicenie_cykl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            for (int i = 1; i <= 10000; i++)
            {
                if (i <= 100)
                if (i >= 50)
                {
                    Console.WriteLine(i);
                }            

            }
            /*
                          Start: i = 1

             Check condition: 1 <= 10000 → true

             Run body: print 1

             Step: i++ → i = 2

             Check condition: 2 <= 10000 → true

             Run body: print 2

             Step: i = 3

             … repeats …

             When i = 10001: condition 10001 <= 10000 → false, loop ends.         
               
            for (int i = 100; i > 0; i--)
            {
                Console.WriteLine(i);
            }
            int a = 1;
            while (a <= 100)
            
            {
                Console.WriteLine(a);
                a++;
            }
            //basically while we can use as for but it will repeat to infinity if while = true


            while (true)
            {
                while (true)
                {
                    Console.WriteLine("if you want to be greeted type pozdrav, if you want to exit write exit or odchod");
                    string input = Console.ReadLine();

                    if (input == "exit" || input == "odchod")
                        break;

                    if (input == "pozdrav")
                        Console.WriteLine("ahoj");
                }
               Console.WriteLine("are you sure?");
               string input2 = Console.ReadLine();
               if (input2 == "yes" || input2 == "da")
                   break;
            }
            */
            Console.WriteLine("how many lines do you want");
            string input = Console.ReadLine();
            int lines = int.Parse(input);
            Console.WriteLine("from what character");
            string character = Console.ReadLine();
              



            for ( int i = 1;  i <= lines ; i++)
            {
                string row = character;
                for ( int j = 1; j <= i; j++)
                {
                    row += character;
                }
                Console.WriteLine(row);
            }























        }
    }
}
