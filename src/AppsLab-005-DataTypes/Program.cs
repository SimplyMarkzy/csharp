using System;
using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* bool isAdult = false;
             Console.WriteLine(isAdult);

             Console.WriteLine("Hello Markzy");
             int MyAge = 15;
             Console.WriteLine(MyAge);
             float pi = 3.14f;
             Console.WriteLine(pi);
             */
            // string name = "Markzy";
            /*Console.WriteLine(name);
            char gender = 'P';
            Console.WriteLine(gender);
           */
            /*int a = 10;
            int b = 5;
            int sum = a + b;
            Console.WriteLine(sum);
            int sum1 = a - b;
            Console.WriteLine(sum1);
            these are for mathematics operations like +-*/
            /*float d = 150;
            float f = 20;
            float sum3 = d/f;
            Console.WriteLine(sum3);
            Console.WriteLine("maj nejm is radim");
            //int of birth day,month,year
            int birthDay = 13;
            int birthMonth = 1;
            int birthYear = 2010;
            //sum of birth day,month,year
            int birthSum = birthDay + birthMonth + birthYear;
            Console.WriteLine(birthSum);
            //sum of birthsum*10
            int sum4 = birthSum * 10;
            Console.WriteLine(sum4);
            //sum of day of birth plus birthmonth times birth year
            int sumTotal = (birthDay + birthMonth) * birthYear;
            Console.WriteLine(sumTotal);
            //sum of my name plush year of birth 
            Console.WriteLine(name + birthYear + (birthDay + birthMonth));
            bool result = 6 > 3;
            Console.WriteLine(result);
            // exclemation mark equals nerovna sa           
            bool result1 = 6 !< 3;
            Console.WriteLine(result1); */

            /* Console.WriteLine("Zadaj meno");
            string meno = Console.ReadLine();
            
            Console.WriteLine("zadaj vek");
            string vek = Console.ReadLine();
            
            int vektvoj = int.Parse(vek);
            int rok = 2025;
            int tvojvek = (rok - vektvoj);
            
            Console.WriteLine("Ahoj " + meno + " narodil si sa v roku " + tvojvek);
            
            if (tvojvek > 2000)
            {
                Console.WriteLine("narodil si sa po roku 2000");
            }
            else if (tvojvek == 2000) 
            {
                Console.WriteLine("narodil si sa v roku 2000");
            }
            else
            {
                Console.WriteLine("narodil si sa pred rokom 2000");
            }
            
            Console.WriteLine("zadaj znamku z angliny");
            string za = Console.ReadLine();
            int zang = int.Parse(za);

            Console.WriteLine("zadaj znamku z matiky");
            string zm = Console.ReadLine();
            int zmat = int.Parse(zm);

            if (zmat <= 3 && zang <= 3)
            {
                Console.WriteLine("mozes ist");
            }
            else
            {
                Console.WriteLine("nikam nejdes");
            }
            */
            Console.WriteLine("zadaj prve cislo");
            string prve  = Console.ReadLine();
            double prvee = double.Parse(prve);

            Console.WriteLine("zadaj znak");
            string znak = Console.ReadLine();

            Console.WriteLine("zadaj druhe cislo");
            string druhe = Console.ReadLine();
            Double druhee = Double.Parse(druhe);

            if (znak == "+")
            {
                Console.WriteLine(prvee + druhee);
            }
            else if (znak == "-")
            {
                Console.WriteLine(prvee - druhee);
            }
            else if (znak == "*")
            {
                Console.WriteLine(prvee * druhee);
            }
            else if (znak == "/")
            {
                Console.WriteLine(prvee / druhee);
            }





        }
    }
}

