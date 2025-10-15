using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace work_with_data
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // we are gonna work with data in this file :)
            string[] text = File.ReadAllLines("People_100.csv");
            MoneyCountAverage(text);
            AllSocialSecurityNumbers(text);
            NameWithLeastMoney(text);
        }
        public static void MoneyCountAverage(string[] text)
        {
            int sum = 0;
            foreach (string line in text.Skip(1))
            {
                string[] splits = line.Split(';');
                int value = int.Parse(splits[4]);
                sum += value;
            }
            Console.WriteLine(sum / (text.Length - 1));

        }
        public static void AllSocialSecurityNumbers(string[] text)
        {
            foreach (string line in text.Skip(1))
            {
                string[] splits = line.Split(';');
                string social = splits[2];
                Console.WriteLine(social);
            }
        }
        public static void NameWithLeastMoney(string[] text)
        {
            string name = "";
            int min = int.MaxValue;
            foreach (string line in text.Skip(1))
            {
                string[] splits = line.Split(';');
                int value = int.Parse(splits[4]);
                if (value < min)
                {
                    min = value;
                    name = splits[0]  +  splits[1];
                    
                }
            }
            Console.WriteLine(name);
        }










    }
}
