﻿using System;

namespace EmpWageComputation
{
    public class Program
    {
        static void Main(string[] args)
        {
            int Is_Part_Time = 1;
            int Is_full_time = 2;
            int Emp_Rate_per_Hour=20;
           
            int Emp_Hour= 0;
            int Emp_Wage=0;
            Random random = new Random();
            int EmpCheck = random.Next(0, 2);
            if (Is_full_time == EmpCheck) 
            {
                Emp_Hour = 8;

            }
            else if(Is_Part_Time == EmpCheck)
            {
                Emp_Hour = 4;
            }
            else
            {
                Emp_Hour = 0;
            }
            Emp_Wage = Emp_Rate_per_Hour * Emp_Hour;
            Console.WriteLine("Emp_Wage:"+Emp_Wage);
            
        }
    }
}


