using System.Runtime.InteropServices;

namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ct = 0;
            for (int i = 0; i < 10000; i++)
            {
                bool result = Prob();
                if (result == true )
                {
                   ++ct;
                }
            }
                Console.WriteLine("True bolo: " + ct);
        }
        public static  bool Prob()
        {
            Random random = new Random();
            int number = random.Next(100);
            

            if (number <= 73)
            { 
            return true;
            }
            else
            {
                return false;
            }
            
            

        }
    }
}
