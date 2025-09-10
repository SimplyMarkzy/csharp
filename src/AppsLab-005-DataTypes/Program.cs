using System;
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
            string name = "Markzy";
             /*Console.WriteLine(name);
             char gender = 'P';
             Console.WriteLine(gender);
            */
            int a = 10;
            int b = 5;
            int sum = a + b;
            Console.WriteLine(sum);
            int sum1 = a - b;
            Console.WriteLine(sum1);
            //these are for mathematics operations like +-*/
            float d = 150;
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
            Console.WriteLine(result1);





        }
    }
}

