/* 
 * This program calculate MPG given miles driven and gallons used.
 * 
 * User inputs gallons used (e.g., 3) and miles driven (e.g., 60).
 * 
 * Program uses exception handling to check for numeric inputs and division by zero,
 * and logic to check for unreasonable input (e.g., -1 or 1000).
 */

using System;
using static System.Console;

namespace CalculateMPG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int milesDriven;
            int gallonsUsed;
            int milesPerGallon;

            try
            {
                //Prompt user for miles driven
                WriteLine("Please enter the number of miles driven: ");
                milesDriven = Convert.ToInt32(ReadLine());

                //Check for reasonable input
                if (milesDriven < 0 || milesDriven > 1000)
                {
                    WriteLine("Invalid entry! Enter a positive value up to 1000: ");
                    milesDriven = Convert.ToInt32(ReadLine());
                }

                //Prompt user for gallons used
                WriteLine("Enter the number of gallons used: ");
                gallonsUsed = Convert.ToInt32(ReadLine());

                //Check for reasonable input
                if (gallonsUsed < 0)
                {
                    WriteLine("Invalid entry! Enter a positive value: ");
                    gallonsUsed = Convert.ToInt32(ReadLine());
                }

                //Calculate miles per gallon
                milesPerGallon = milesDriven / gallonsUsed;
            }
            //Incorrect input type exception
            catch (FormatException error)
            {
                milesPerGallon = 0;
                WriteLine(error.Message);
            }

            //Dividing by zero exception
            catch (DivideByZeroException error)
            {
                milesPerGallon = 0;
                WriteLine(error.Message);
            }

            WriteLine("Your miles per gallon is: " + milesPerGallon);
        }
    }
}
