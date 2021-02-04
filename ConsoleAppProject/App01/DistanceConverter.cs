namespace ConsoleAppProject.App01
    using System;
{
    /// <summary>
    /// Please describe the main features of this App
    /// </summary>
    /// <author>
    /// Alex Clementss
    /// </author>
    /// ///
    ///
    public class DistanceConverter
    {

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
            }
        /// <summary>
        /// 
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
        private void CalculateFeet()
            {
            feet = miles * 5280;
            }
        /// <summary>
        /// Outputs Feet
        /// </summary>
        private void OutputFeet()
            {
            Console.WriteLine(miles + " miles is " + feet + " feet!");
            }
    }
}

