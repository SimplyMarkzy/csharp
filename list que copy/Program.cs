namespace list_que_copy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();

            //bool running = true;
            while ( /*running*/true)
            {
                string command = Console.ReadLine();
                switch (command)
                {
                    case "add":
                        {
                            AddNumber(list);
                            break;
                        }
                    case "del":
                        {
                            RemoveNumber(list);
                            break;
                        }
                    case "deli":
                        {
                            RemoveNumberAtPosition(list);
                            break;
                        }
                    case "end":
                        {
                            return;
                        }
                    case "list":
                        {
                            ListNumbers(list);
                            break;
                        }
                    case "has":
                        {
                            CheckIfListHasNumber(list);
                            break;
                        }
                    case "count":
                        {
                            CountAllNumbers(list);
                            break;
                        }
                    case "avg":
                        {
                            AverageOfNumbers(list);
                            break;
                        }
                    case "max":
                        {
                            MaxNumber(list);
                            break;
                        }
                    case "min":
                        {
                            MinNumber(list);
                            break;
                        }
                    case "help":
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
                            break;
                        }
                    case "get":
                        {
                            GetNumberAtPosition(list);
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("unknown command, type ´help´ for help");
                            break;
                        }
                }
            }
        }
        public static void AddNumber(List<int> list)
        {
            Console.WriteLine("What number do you want to add");
            string numbers = Console.ReadLine();
            int numberint = int.Parse(numbers);
            list.Add(numberint);
        }
        public static void RemoveNumber(List<int> list)
        {
            Console.WriteLine("What number do you want to delete");
            string number = Console.ReadLine();
            int numberint = int.Parse(number);
            list.Remove(numberint);
        }
        public static void ListNumbers(List<int> list)
        {
            foreach (int i in list)
            {
                Console.WriteLine(i);
            }
        }
        public static void RemoveNumberAtPosition(List<int> list)
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
        public static void CheckIfListHasNumber(List<int> list)
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
        public static void CountAllNumbers(List<int> list)
        {
            int sum = 0;
            foreach (int i in list)
            {
                sum += i;
                Console.WriteLine(sum);
            }
        }
        public static void AverageOfNumbers(List<int> list)
        {
            int sum = 0;
            foreach (int i in list)
            {
                sum += i;
            }
            int sum1 = sum / list.Count;
            Console.WriteLine(sum1);
        }
        public static void MaxNumber(List<int> list)
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
        public static void MinNumber(List<int> list)
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
        public static void GetNumberAtPosition(List<int> list)
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
