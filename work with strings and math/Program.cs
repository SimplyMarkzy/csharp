using System.Reflection.Metadata;

namespace work_with_strings_and_math
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int result = Add(a, b ,5, 10, 15);
            Console.WriteLine(result);
        }
        public static int Add(int a, int b, int c, int d, int e)
        {
          
           


            int allnumb = a + b + c + d + e;
            return allnumb;

        }
    }
}
