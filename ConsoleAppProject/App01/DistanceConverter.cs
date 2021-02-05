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
        
        public const double METRES_IN_MILES = 1609.34;
        
        public const double FEET_IN_METRES = 3.28084;

        public const string FEET = "feet";

        public const string METRES = "metres";

        public const string MILES = "miles";

        // privare attributes

        private string fromUnit;
        private string toUnit;

        // constructor
        public DistanceConverter()
        {
            fromUnit = MILES;
            toUnit = FEET;
            }


        /// <summary>
        /// The run method runs each of the below methods
        /// </summary
        public void ConvertDistance()
        {
            fromUnit = SelectUnit("Please select the from distance unit > ");
            toUnit = SelectUnit("Please select the to distance unit > ");

            OutputHeading($"Converting {fromUnit} to {toUnit}");

            fromDistance = InputDistance($"Enter the number of {fromUnit} >");

            CalculateDistance();

            OutputDistance();
        }

        private void CalculateDistance()
        {
            if(fromUnit == MILES && toUnit == FEET)
            {
                toDistance = fromDistance * FEET_IN_MILES;
            }
            else if(fromUnit == FEET && toUnit == MILES)
            {
                toDistance = fromDistance / FEET_IN_MILES;
            }
            else if(fromUnit = METRES && toUnit = MILES)
            {
                toDistance = fromDistance * METRES_IN_MILES;
            }
        }

        private string SelectUnit(string prompt)
        {
            string choice = DisplayChoices(prompt);

            return ExecuteChoices(choice);
        }

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

            return null;
        }

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
    }
    

        private double InputDistance(string prompt)
        {
            Console.Write(prompt);
            string value = Console.ReadLine();
            return Convert.ToDouble(value);
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



    }
}

