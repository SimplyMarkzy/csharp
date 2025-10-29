using System.Security.Cryptography.X509Certificates;

namespace task_oop
{
    internal class Program
    {
        static void Main(String[] args)
        {
            Student student1 = new Student();
            student1.Name = "Marek";
            student1.Age = 15;
            student1.Adress = "Krakow";
            student1.Gender = 'M';
            
            Student  student2 = new Student();
            student2.Name = "JOZKO";
            student2.Age = 16;
            student2.Adress = "Warszawa";
            student2.Gender = 'H';
            Console.WriteLine(student1.IsAdult());
            Console.WriteLine(student2.GetInfo());
        }
    }
}
