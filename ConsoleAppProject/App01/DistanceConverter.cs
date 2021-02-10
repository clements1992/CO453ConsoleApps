using System;
namespace ConsoleAppProject.App01
{
    /// <summary>
    /// This converts three different metrics
    /// </summary>
    /// <author>
    /// Alex Clements 21922124
    /// </author>
    /// ///
    ///
    public class DistanceConverter
    {

        public const int FEET_IN_MILES = 5280;

        public const double METRES_IN_MILES = 1609.34;

        public const double FEET_IN_METRES = 3.28084;

        public const string FEET = "feet";

        public const string METRES = "metres";

        public const string MILES = "miles";

        // private attributes

        private string fromUnit;
        private string toUnit;
        private double fromDistance;
        private double toDistance;

        // constructor
        public DistanceConverter()
        {
            fromUnit = MILES;
            toUnit = FEET;
        }


        /// <summary>
        /// The convert distance method runs each of the below methods in the order displayed
        /// </summary
        public void ConvertDistance()
        {
            Console.WriteLine("Welcome to the Converter");
            Console.WriteLine("By Alex Clements");

            fromUnit = SelectUnit(" Please select the from distance unit > ");
            toUnit = SelectUnit(" Please select the to distance unit > ");

            Console.WriteLine($" Converting {fromUnit} to {toUnit}");

            fromDistance = InputDistance($"\n Enter the number of {fromUnit} > \n");

            CalculateDistance();

            OutputDistance();
        }


        /// <summary>
        /// The calculate distance method is called from the convert distance method and contains the math to convert each metric
        /// </summary
        private void CalculateDistance()
        {
            if (fromUnit == MILES && toUnit == FEET)
            {
                toDistance = fromDistance * FEET_IN_MILES;
            }
            else if (fromUnit == FEET && toUnit == MILES)
            {
                toDistance = fromDistance / FEET_IN_MILES;
            }
            else if (fromUnit == METRES && toUnit == MILES)
            {
                toDistance = fromDistance / METRES_IN_MILES;
            }
            else if (fromUnit == MILES && toUnit == METRES)
            {
               toDistance = fromDistance * METRES_IN_MILES;
            }
            else if (fromUnit == FEET && toUnit == METRES)
            {
                toDistance = fromDistance / FEET_IN_METRES;
            }
            else if (fromUnit == METRES && toUnit == FEET)
            {
                toDistance = fromDistance * FEET_IN_METRES;
            }
        }

        /// <summary>
        /// The select unit lets the user choose two metrics/units
        /// </summary
        private string SelectUnit(string prompt)
        {
            string choice = DisplayChoices(prompt);

            string unit = ExecuteChoices(choice);
            Console.WriteLine($" You have chosen {unit}");
            return unit;
        }

        /// <summary>
        /// The execute choices assigns 1,2 and 3 to each of the three metrics so the user can type the corresponding number
        /// </summary
        private static string ExecuteChoices(string choice)
        {
            if (choice.Equals("1"))
            {
                return FEET;
            }

            else if (choice.Equals("2"))
            {
                return METRES;
            }

            else if (choice.Equals("3"))
            {
                return MILES;
            }

            Console.WriteLine("invalid choice");
            return null;

        }

        /// <summary>
        /// The display choices method displays the numbers 1,2 and 3
        /// </summary
        private static string DisplayChoices(string prompt)
        {
            Console.WriteLine();
            Console.WriteLine($"1. {FEET}");
            Console.WriteLine($"2. {METRES}");
            Console.WriteLine($"3. {MILES}");

            Console.WriteLine(prompt);
            string choice = Console.ReadLine();
            return choice;
        }

        /// <summary>
        /// The input distance method takes the users requested distance and converts it to a double
        /// </summary
        private double InputDistance(string prompt)
        {
            Console.Write(prompt);
            string value = Console.ReadLine();
            return Convert.ToDouble(value);
        }

        /// <summary>
        /// The output distance displays: the from distance, the from unit, the too distance and the too unit
        /// </summary
        private void OutputDistance()
        {
            Console.WriteLine($" {fromDistance} {fromUnit} is {toDistance} {toUnit}");
        }


        /// <summary>
        /// The output heading displays the title and the creators name
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

        


    }
}

