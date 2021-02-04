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
                miles = InputDistance("Please enter the number of miles > ");
                CalculateFeet();
                OutputDistance(miles, nameof(miles), feet, nameof(feet));
                OutputEnding();
            }

        /// <summary>
        /// The run method runs each of the below methods
        /// </summary
        public void FeetToMiles()
        {
            OutputHeading("Convert Feet To Miles");
            feet = InputDistance("Please enter the number of feet > ");
            CalculateMiles();
            OutputDistance(feet, nameof(feet), miles, nameof(miles));
            OutputEnding();
        }

        public void MilesToMetres()
        {
            OutputHeading("Convert Miles To Metres");
            miles = InputDistance("Please enter the number of miles > ");
            CalculateMetres();
            OutputDistance(miles, nameof(miles), metres, nameof(metres));
            OutputEnding();

        }

        private double InputDistance(string prompt)
        {
            Console.Write(prompt);
            string value = Console.ReadLine();
            return Convert.ToDouble(value);
        }



        private void CalculateMetres()
        {
            metres = miles * METRES_IN_MILES;
        }

        private void CalculateMiles()
        {
            miles = feet / FEET_IN_MILES;
        }

        /// <summary>
        /// Calculates Feet
        /// </summary>
        /// 
        private void CalculateFeet()
        {
            feet = miles * FEET_IN_MILES;
        }



        private void OutputDistance(
            double fromDistance, string fromUnit,
            double toDistance, string toUnit)
            {
            Console.WriteLine($" {fromDistance} {fromUnit} is {toDistance} {toUnit}");
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

