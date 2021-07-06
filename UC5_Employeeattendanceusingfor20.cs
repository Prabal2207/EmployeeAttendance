using System;
namespace Employeeattendance
{
    public class UC5_Employeeattendanceusingfor20
    {

        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        public const int EMP_WAGE_PER_HOUR = 20;
        public const int NUM_OF_WORKING_DAYS = 20;

        public static void calculationfor20days()
        {
            //Variable
            int empHrs = 0;
            int empWage = 0;
            int totalempwage = 0;
            for (int day = 0; day < NUM_OF_WORKING_DAYS; day++)
            {
                Random random = new Random();
                //Computation
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                empWage = empHrs * EMP_WAGE_PER_HOUR;
                totalempwage = totalempwage + empWage;
                Console.WriteLine("Emp Wage : " + empWage);
            }

            Console.WriteLine("Total Emp Wage : " + totalempwage);


        }
    }
}
