using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;

namespace list_queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
          List<int> list = new List<int>();
           while (true)
           {
                string command = Console.ReadLine();
                if (command == "add")
                {
                    Console.WriteLine("What number do you want to add");
                    string number = Console.ReadLine();
                    int numberint = int.Parse(number);
                    list.Add(numberint);

                }
                if (command == "del")
                {
                    Console.WriteLine("What number do you want to delete");
                    string number = Console.ReadLine();
                    int numberint = int.Parse(number);
                    list.Remove(numberint);
                }
                if (command == "deli")
                {
                    Console.WriteLine("The number at what position do you want to remove");
                    
                    string number = Console.ReadLine();
                    int numberint = int.Parse(number);
                    if (numberint >= 0 && numberint < list.Count)
                    {
                        list.RemoveAt(numberint);
                    }
                    else
                    {
                        Console.WriteLine("bad index");
                    }
                }
                if (command == "end")
                {
                    break;
                }
                if (command == "list")
                {
                    foreach (int i in list)
                    {
                        Console.WriteLine(i);
                    }
                }
                if (command == "has")
                {
                    Console.WriteLine("What number do you want to check if the list has?");
                    string number = Console.ReadLine();
                    int numberint = int.Parse(number);
                    bool hasnumberint = list.Contains(numberint);
                    if (hasnumberint)
                    {
                        Console.WriteLine("true");
                    }
                    else
                    {
                        Console.WriteLine("false");
                    }
                }
                if (command == "count")
                {
                    int sum = 0;
                    foreach (int i in list)
                    {
                        sum += i;
                        Console.WriteLine(sum);
                    }                
                }
                if (command == "avg")
                {
                    int sum = 0;
                    foreach(int i in list)
                    {
                        sum += i;
                        
                    }
                    int sum1 = sum / list.Count;
                    Console.WriteLine(sum1);
                }
                if (command == "max")
                {
                    int max = list[0];
                    foreach (int num in list)
                    {
                        if (num > max)
                        {
                            max = num;
                        }
                    }
                    Console.WriteLine(max);
                }

                if (command == "min")
                {
                    int min = list[0];
                    foreach (int num in list)
                    {
                        if (num < min)
                        {
                            min = num;
                        }
                    }
                    Console.WriteLine(min);
                }
                if (command == "help")
                {
                    Console.WriteLine("type ´add´ to add a number into the list");
                    Console.WriteLine("type ´del´ to remove the number from the list");
                    Console.WriteLine("type ´deli´ to remove the a number from the chosen position");
                    Console.WriteLine("type ´has´ to check if the chosen number is in the list");
                    Console.WriteLine("type ´list´ to open the list");
                    Console.WriteLine("type ´end´ to exit the console");
                    Console.WriteLine("type ´avg´ to calculate the average number on list");
                    Console.WriteLine("type ´min´ to get the biggest number on list");
                    Console.WriteLine("type ´max´ to get the smallest number on list");
                    Console.WriteLine("type ´get´ to find the number on chosen position");
                }
                if (command == "get")
                {
                    Console.WriteLine("pick a position of a number to get");
                    string numberTxt = Console.ReadLine();
                    int number = int.Parse(numberTxt);

                    if (number >= 0 && number < list.Count)
                    {
                        Console.WriteLine(list[number]);
                    }
                    else
                    {
                        Console.WriteLine("this position is not in the list");
                    }

                }




            }
            
        }
    }
}
