
using System.Reflection.Metadata.Ecma335;

namespace game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string HeroName = "Player1";
            hero myHero = new hero(HeroName);
            enemies enemy = new enemies("Goblin", 20, 5);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(@"
                  ██████╗ ███████╗ █████╗ ██╗     ███╗   ███╗
                  ██╔══██╗██╔════╝██╔══██╗██║     ████╗ ████║
                  ██████╔╝█████╗  ███████║██║     ██╔████╔██║
                  ██╔═══╝ ██╔══╝  ██╔══██║██║     ██║╚██╔╝██║
                  ██║     ███████╗██║  ██║███████╗██║ ╚═╝ ██║
                  ╚═╝     ╚══════╝╚═╝  ╚═╝╚══════╝╚═╝     ╚═╝
                                           OF SHATTERED STEEL");
            Console.WriteLine("\n                      Press ENTER to begin your descent...");
            Console.ReadKey();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("State your name so called hero: ");
            HeroName = Console.ReadLine();



            var stats = new Attributes();
            string[] names = { "Health", "Strength", "Mana", "Energy" };
            int[] values = { stats.Health, stats.Strength, stats.Mana, stats.Energy };
            int selected = 0;

            bool finsihed = false;
            while (!finsihed)
            {

                ConsoleKeyInfo key;
                do
                {
                    Console.Clear();
                    Console.WriteLine("=== ATTRIBUTE ALLOCATION ===");
                    Console.WriteLine($"Points left: {stats.PointsLeft}\n");

                    // draw the list
                    for (int i = 0; i < names.Length; i++)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        string pointer = i == selected ? ">" : " ";
                        Console.Write($"{pointer} {names[i],-10}: {values[i],2}  ");

                        // look for the slider 
                        Console.Write("[");
                        Console.Write(new string('#', values[i]));
                        Console.WriteLine(new string('-', 10 - values[i]) + "]");
                    }
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nUse arrows to move, or adjust, Enter to confirm.");

                    key = Console.ReadKey(true);

                    if (key.Key == ConsoleKey.UpArrow) selected = (selected - 1 + names.Length) % names.Length;
                    if (key.Key == ConsoleKey.DownArrow) selected = (selected + 1) % names.Length;

                    if (key.Key == ConsoleKey.RightArrow && stats.PointsLeft > 0 && values[selected] < 10)
                    {
                        values[selected]++;
                        stats.PointsLeft--;
                    }

                    if (key.Key == ConsoleKey.LeftArrow && values[selected] > 0)
                    {
                        values[selected]--;
                        stats.PointsLeft++;
                    }

                } while (key.Key != ConsoleKey.Enter);
                // save the final values back into the class
                stats.Health = values[0];
                stats.Strength = values[1];
                stats.Mana = values[2];
                stats.Energy = values[3];
                if (stats.PointsLeft > 0)
                {
                    Console.Clear();
                    Console.WriteLine("You must allocate all points before proceeding!");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey(true);
                    continue;
                }
               
                Console.Clear();
                Console.WriteLine("Final build:");
                Console.WriteLine($"Health:   {stats.Health}");
                Console.WriteLine($"Strength: {stats.Strength}");
                Console.WriteLine($"Mana:     {stats.Mana}");
                Console.WriteLine($"Energy:   {stats.Energy}");
                Console.WriteLine("\nPress any key to begin your adventure...");
                Console.ReadKey(true);
            }
        }
    }

    
}
















