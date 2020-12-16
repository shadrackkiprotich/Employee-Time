using System;

namespace Employee_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your overtime hours worked?");
            int number =Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("Number of hours Absent from work");
            int  hoursabsent = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine ($"Employee  {name} has worked for {number } overtime hours. " +
                $"The Number of hours absent from work is {hoursabsent} ");
            Console.ReadKey();

        }
    }
}
