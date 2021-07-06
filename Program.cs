using System;
using Employeeattendance.FinalSolution;

namespace Employeeattendance
{
    class Program
    {
        static void Main(string[] args)
        {


            // UC2_Employeedailywage.Employeedailywage();
            // UC3_Employeeparttimewage.Employeedailywage();
            //UC4_Employeeparttimeusingcase.Employeedailywage();
            //UC5_Employeeattendanceusingfor20.calculationfor20days();
            //UC6_Employeeattendancewhile.calusingwhile();
            // UC7_employeewageusingmethod.computeEmpwage();
            // UC8_Employeewagediffcompany.computeEmpWage("DMart", 20, 2, 10);
            //UC8_Employeewagediffcompany.computeEmpWage("Reliance", 20, 4, 20);

            /*  #region UC9_Impletation
              EmpWageBuilderObject dMart = new EmpWageBuilderObject("DMart", 20, 2, 10);
              EmpWageBuilderObject reliance = new EmpWageBuilderObject("Reliance", 10, 4, 20);
              dMart.computeEmpWage();
              Console.WriteLine(dMart.toString());
              reliance.computeEmpWage();
              Console.WriteLine(reliance.toString());
              #endregion*/

            /* #region UC10_Impletation
             EmpWageBuilderArray empWageBuilder = new EmpWageBuilderArray();
                 empWageBuilder.addCompanyEmpWage("DMart", 20, 2, 10);
                 empWageBuilder.addCompanyEmpWage("Reliance", 10, 4, 20);
                 empWageBuilder.computeEmpWage();
             #endregion*/
            #region UC10
            
            EmpWageBuilder empWageBuilder = new EmpWageBuilder();
            empWageBuilder.addCompanyEmpWage("DMart", 20, 2, 10);
            empWageBuilder.addCompanyEmpWage("Reliance", 10, 4, 20);
            empWageBuilder.computeEmpWage();
            #endregion
            Console.ReadKey();



            Console.ReadKey();
        }
        public void empcheck()
        {
            int IS_FULL_Time = 1;
            Random random = new Random();
            int result = random.Next(0, 2);
            if (result == IS_FULL_Time)
            {
                Console.WriteLine("Employee is present");
            }
            else
            {
                Console.WriteLine("Employee is absent");
            }
        }
    }
}
