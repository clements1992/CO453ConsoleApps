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
        
        public const int METRES_IN_MILES = 1609;

        private double feet;

        private double metres;

        private double miles;



        /// <summary>
        /// The run method runs each of the below methods
        /// </summary
        public void MilesToFeet()
            {   
                OutputHeading("Convert Miles To Feet");
                InputMiles();
                CalculateFeet();
                OutputFeet();
                OutputEnding();
            }

        /// <summary>
        /// The run method runs each of the below methods
        /// </summary
        public void FeetToMiles()
        {
            OutputHeading("Convert Feet To Miles");
            InputFeet();
            CalculateMiles();
            OutputMiles();
            OutputEnding();
        }

        public void MilesToMetres()
        {
            OutputHeading("Convert Miles To Metres");
            InputMiles();
            CalculateMetres();
            OutputMetres();
            OutputEnding();

        }

        private void OutputMetres()
        {
            Console.WriteLine(miles + " miles is " + metres + " Metres!");
        }

        private void CalculateMetres()
        {
            metres = miles * METRES_IN_MILES;
        }

        private void OutputMiles()
        {
                Console.WriteLine();
                Console.WriteLine(feet + " feet is " + miles + " miles!");
                Console.WriteLine();
        }
        
        private void CalculateMiles()
        {    
                miles = feet / FEET_IN_MILES;
        }

        private void InputFeet()
        {
            Console.Write("Please enter the number of feet > ");
            string value = Console.ReadLine();
            feet = Convert.ToDouble(value);
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
            Console.WriteLine();
            Console.WriteLine(miles + " miles is " + feet + " feet!");
            Console.WriteLine();
            }


        /// <summary>
        /// Everytime the run method is used it will print out the OutputHeading
        /// </summary>
        /// 
        private void OutputHeading(String title)
        {
            Console.WriteLine();
            Console.WriteLine(" -----------------");
            Console.WriteLine($" {title} ");
            Console.WriteLine(" by Alex Clements");
            Console.WriteLine(" ------------------ ");
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

