using System;

namespace PayCalculationSystem
{
    class Program
    {
        // Standard rate and hours
        const double standardRate = 80.0;
        const int standardHours = 56;

        // Method to calculate the gross pay
        public static double GetGrossPay(int hoursWorked)
        {
            double grossPay;

            if (hoursWorked <= standardHours)
            {
                // If hours worked is less than or equal to standard hours
                grossPay = hoursWorked * standardRate;
            }
            else
            {
                // If hours worked is more than standard hours, calculate overtime pay
                int overtimeHours = hoursWorked - standardHours;
                grossPay = (standardHours * standardRate) + (overtimeHours * (standardRate * 1.5));
            }

            return grossPay;
        }

        // Method to calculate the tax
        public static double CalculateTax(double grossPay)
        {
            const double taxRate = 0.02;
            return grossPay * taxRate;
        }

        // Method to calculate the net pay
        public static double CalculateNetPay(int hoursWorked)
        {
            double grossPay = GetGrossPay(hoursWorked);
            double tax = CalculateTax(grossPay);
            double netPay = grossPay - tax;

            return netPay;
        }

        static void Main(string[] args)
        {
            // Input: Number of hours worked
            Console.WriteLine("Enter the number of hours worked:");
            int hoursWorked = int.Parse(Console.ReadLine());

            // Calculate and display net pay
            double netPay = CalculateNetPay(hoursWorked);
            Console.WriteLine($"The calculated Net Pay is ${netPay:F2}");

            // Pause before closing
            Console.ReadLine();
        }
    }
}
