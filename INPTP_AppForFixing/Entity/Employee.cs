﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INPTP_AppForFixing
{
    public class Employee
    {
        private int id;
        private string firstName;
        private string lastName;
        private string job; 
        private DateTime ourBirthDate;
        private double monthlySalaryCZK;      
        private static double taxRate = 0.21;


        public int Id { get => id; set => id = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Job { get => job; set => job = value; }
        public DateTime OurBirthDate { get => ourBirthDate; set => ourBirthDate = value; }
        public double MonthlySalaryCZK { get => monthlySalaryCZK; set => monthlySalaryCZK = value; }
        public static double TaxRate { get => taxRate; }

        public Employee() { }

        public Employee(int id, string firstName, string lastName,string job, DateTime ourBirthDate, double monthlySalaryCZK) {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.job = job;
            this.ourBirthDate = ourBirthDate;
            this.monthlySalaryCZK = monthlySalaryCZK;
        }

        /// <summary>
        /// This method gets age of employee
        /// </summary>
        /// <returns>Age of employee</returns>
        public int GetAge()
        {
            DateTime today = DateTime.Now;
            int age = today.Year - OurBirthDate.Year;

            if (OurBirthDate > today.AddYears(-age))
                return --age;

            return age;
        }

        /// <summary>
        /// Method to count sum of 12 salaries (one per month) of the employee
        /// based on attribute monthlySalaryCZK
        /// </summary>
        /// <returns>Sum of all the 12 salaries</returns>
        public virtual double CalcYearlySalaryCZK()
        {
            return MonthlySalaryCZK * 12;
        }
            
        /// <summary>
        /// Method to count the net income of the employee
        /// based on attribute taxRate
        /// calls method CalcYearlySalaryCZK
        /// </summary>
        /// <returns>Net income of the employee</returns>
        public virtual double CalcYearlyIncome()
        {
            return CalcYearlySalaryCZK() * (1 - TaxRate);
        }

        public override string ToString() {
            return "ID:  " + Id + "; NAME: " + FirstName + " " + LastName + "; JOB:" + Job + "; SALARY: " + MonthlySalaryCZK; 
        }
    }
}
