using System;
namespace ConsoleAppProject.App01
{
    /// <summary>
    /// This app changes miles to feet
    /// </summary>
    /// <author>
    /// Alex Clements 21922124
    /// </author>
    /// ///
    ///
    public class DistanceConverter
    {

        public const int FEET_IN_MILES = 5280;

        private double miles;

        private double feet;
        /// <summary>
        /// The run method runs each of the below methods
        /// </summary
        public void Run()
            {   
                OutputHeading();
                InputMiles();
                CalculateFeet();
                OutputFeet();
                OutputEnding();
            }

        /// <summary>
        /// Everytime the run method is used it will print out the OutputHeading
        /// </summary>
        /// 
        private void OutputHeading()
        {
                Console.WriteLine();
                Console.WriteLine(" -----------------" );
                Console.WriteLine(" Convert Miles to Feet ");
                Console.WriteLine(" by Alex Clements");
                Console.WriteLine(" ------------------ ");
        }

        /// <summary>
        /// This uses a console that allows the user to write and save it as a string, the Convert then changes the String into a double
        /// </summary>
        /// 
       private void InputMiles()
            {
            Console.Write("Please enter the number of miles > ");
            string value = Console.ReadLine();
            miles = Convert.ToDouble(value);
            }

        /// <summary>
        /// Calculates Feet
        /// </summary>
        /// 
        private void CalculateFeet()
            {
            feet = miles * FEET_IN_MILES;
            }

        /// <summary>
        /// Outputs Feet
        /// </summary>
        /// 
        private void OutputFeet()
            {
            Console.WriteLine(miles + " miles is " + feet + " feet!");
            }

        /// <summary>
        /// Displays thank you message
        /// </summary>
        /// 
        private void OutputEnding()
        {
            Console.WriteLine();
            Console.WriteLine(" -----------------");
            Console.WriteLine(" Thank you for using the converter ");
            Console.WriteLine(" by Alex Clements");
            Console.WriteLine(" ------------------ ");
        }
    }
}

