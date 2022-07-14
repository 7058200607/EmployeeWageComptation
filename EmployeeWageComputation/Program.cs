using System;

namespace EmpWageComputation
{
    public class Program
    {
        static void Main(string[] args)
        {

            int Is_full_time = 1;
            Random random = new Random();
            int EmpCheck = random.Next(0, 2);
            if (Is_full_time == EmpCheck) 
            {
                Console.WriteLine("Employee Is Present");

            }
            else
            {
                Console.WriteLine("Employee Is Absent");
            }
            
        }
    }
}


