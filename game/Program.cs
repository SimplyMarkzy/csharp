namespace game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            hero myHero = new hero();
            enemies enemy1 = new enemies("Goblin", 20, 5);
            Console.WriteLine("Welcome to tihs totally legit battlesim (no joke)");
            while (true)
            {

                enemy1.EnemyAttack(myHero);
                myHero.HeroAttack(enemy1);
                Console.WriteLine("hero hp " + myHero.HP );
                Console.WriteLine("Pepans energy " + myHero.Energy);
                Console.WriteLine("monster hp " + enemy1.HP );
                if (myHero.Energy <= 1)
                {
                    Console.WriteLine("not enough energy bucko");
                    Console.WriteLine("pepan rested +5 energy");
                }
                if (myHero.HP == 0)
                {
                    Console.WriteLine("you ded");
                    break;
                }
            }
        }
    }
}
