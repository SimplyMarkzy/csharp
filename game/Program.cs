
namespace game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            hero myHero = new hero("pepan", hp: 10, dmg: 1, energy: 10, armor: 100000);
            enemies enemy = new enemies("Goblin", 20, 5);

            Console.WriteLine("Welcome to this totally legit battlesim (no joke)");

            int turn = 1;
            while (true)
            {
                Console.ReadKey();
                Console.WriteLine($"\n--- Turn {turn++} ---");

                enemy.EnemyAttack(myHero);     // damage reduction applied here
                myHero.HeroAttack(enemy);      // -2 energy or +5 if low

                Console.WriteLine($"hero hp {myHero.HP}");
                Console.WriteLine($"Pepans energy {myHero.Energy}");
                Console.WriteLine($"monster hp {enemy.HP}");

                if (myHero.HP <= 0)
                {
                    Console.WriteLine("you ded");
                    break;
                }
                if (enemy.HP <= 0)
                {
                    Console.WriteLine("you win");
                    break;
                }
            }
        }
    }
}

