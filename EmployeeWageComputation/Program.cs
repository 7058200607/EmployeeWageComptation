using System;

namespace EmpWageComputation
{
    public class Program
    {
        public const int Is_Part_Time = 1;
        public const int Is_full_time = 2;
        public const int Emp_Rate_per_Hour = 20;
        public const int Num_Of_Working_Days = 20;
        static void Main(string[] args)
        {
            int Emp_Hour = 0;
            int Emp_Wage = 0;
            int Total_Emp_Wage = 0;

            for (int Day = 0; Day <= Num_Of_Working_Days; Day++)
            {
                Random random = new Random();
                int EmpCheck = random.Next(0, 3);
                switch (EmpCheck)
                {
                    case Is_Part_Time:
                        Emp_Hour = 4;
                        break;
                    case Is_full_time:
                        Emp_Hour = 8;
                        break;
                    default:
                        Emp_Hour = 0;
                        break;
                }

                Emp_Wage = Emp_Rate_per_Hour * Emp_Hour;
                Total_Emp_Wage += Emp_Wage;
                Console.WriteLine("Emp_Wage:" + Emp_Wage);
            }
            Console.WriteLine("Total Emp Wage:" + Total_Emp_Wage);
        }
    }
}

