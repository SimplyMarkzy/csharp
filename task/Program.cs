using System.Diagnostics;

namespace task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var teploty = new List<int> { 3, -1, 12, 7, -3, 0, 19, 14, 2, 5, -5, 8 };
            WriteMaxTemperature(teploty);
            WriteMinTemperature(teploty);
            WriteAverageTemperature(teploty);
            WriteTemperaturesAboveAverage(teploty);
            WriteAllTemperatures(teploty);
            RemoveNegativeTemperatures(teploty);
        }
        static void WriteMaxTemperature(List<int> temperatures)
        {
            int max = int.MinValue;
            foreach (var temp in temperatures)
            {
                if (temp > max)
                {
                    max = temp;
                }
            }
            Console.WriteLine("Max temp is " + max);
        }
        static void WriteMinTemperature(List<int> temperatures)
        {
            int min = int.MaxValue;
            foreach (var temp in temperatures)
            {
                if (temp < min)
                {
                    min = temp;
                }
            }
            Console.WriteLine("Min temp is " + min);
        }
        static void WriteAverageTemperature(List<int> temperatures)
        {
            int sum = 0;
            foreach (var temp in temperatures)
            {
                sum += temp;
            }
            double average = (double)sum / temperatures.Count;
            Console.WriteLine($"Average Temperature: {average}");

        }
        static void WriteTemperaturesAboveAverage(List<int> temperatures)
        {
            int suma = 0;
            int sum = 0;
            foreach (var temp in temperatures)
            {
                sum += temp;
            }
            double average = (double)sum / temperatures.Count;
            foreach (var temp in temperatures)
            {
                if (temp > average)
                {
                   suma += 1;
                }
            }
            Console.WriteLine("Temperatures above average: " + suma);
            
        }
        static void RemoveNegativeTemperatures(List<int> temperatures)
        {
            int sum = 0;
            Console.WriteLine("Non-negative temperatures:");
            foreach (var temp in temperatures.ToList())
            {
                if (temp < 0)
                {
                    temperatures.Remove(temp);
                }
                else
                {
                    Console.WriteLine(temp);
                }
            }
        }
        static void WriteAllTemperatures(List<int> temperatures)
        {
            Console.WriteLine("All temperatures:");
            foreach (var temp in temperatures)
            {
                string[] list = temp .ToString().Split(',');
                Console.Write(temp + " ");
            }
               Console.WriteLine();
        }

    }
}
