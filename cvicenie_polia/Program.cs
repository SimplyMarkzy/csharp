namespace cvicenie_polia
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            /*for (int i = 0; i < numbers.Length; i++)
            int[] numbers = new int[6];
            numbers[1] = 15;
            numbers[2] = 2;
            numbers[0] = 1;
            numbers[3] = 3;
            numbers[4] = 4;
            numbers[5] = 20;
            int sum = 0;
            {
                sum += numbers[i];  
            }
            Console.WriteLine(sum);
             foreach (var item  in numbers)
            {
                sum += item;
            }
             Console.WriteLine(sum);
            */
            //cez jeden cyklus naplnit pole hodnotami pomocou write line a nasledne sctitat vsetky hodnoty #
            int[] number = new int[6];
            int sum = 0;
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("zadaj cisla");
                number[i] = int.Parse(Console.ReadLine());
                sum += number[i];
                
            
            }
               Console.WriteLine(sum);






        }
    }
}
