﻿using System;
namespace Employeeattendance.FinalSolution
{
    
        public interface IComputeEmpWage
        {
            void addCompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMnth);
            void computeEmpWage();

            int getTotalWage(string company);
        }

    
}