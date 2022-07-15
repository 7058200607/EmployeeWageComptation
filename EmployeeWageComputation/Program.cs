using System;

namespace EmpWageComputation
{
    public class Program
    {
        public const int Is_Part_Time = 1;
        public const int Is_full_time = 2;
        public const int Emp_Rate_per_Hour = 20;
        public const int Num_Of_Working_Days = 20;
        public const int Max_Hours_In_month = 100; 
        static void Main(string[] args)
        {
            int Emp_Hour = 0;
            int Total_Emp_Hours = 0;
            int Total_Working_Days = 0; 

            while(Total_Emp_Hours<= Max_Hours_In_month && Total_Working_Days< Num_Of_Working_Days)
            {
                Total_Working_Days++;
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


                Total_Emp_Hours+= Emp_Hour;
                Console.WriteLine("Day#:" + Total_Working_Days +"Emp Hours:"+Emp_Hour );
            }
            int Total_Emp_wage = Total_Emp_Hours * Emp_Rate_per_Hour;
            Console.WriteLine("Total Emp Wage:" + Total_Emp_wage);
        }
    }
}

