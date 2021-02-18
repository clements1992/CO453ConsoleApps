using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppProject.App02
{
    public class BMICalculator
    {
        public const double Underweight = 18.5;
        public const double NormalRange = 24.9;
        public const double Overweight = 29.9;

        public const double ObeseLevel1 = 34.9;
        public const double ObeseLevel2 = 39.9;
        public const double ObeseLevel3 = 40.0;

        public const int InchesInFeet = 12;
        public const int PoundsInStones = 14;

        public const string METRIC = "metric";
        public const string IMPERIAL = "imperial";

        private double index;

        private double centimetres;
        private double inches;
        private double kilograms;
        private double metres;
        private double pounds;
        private double stone;
        private double bmi;

        public void Run()
        {

            Heading();
            string unit = SelectUnit();


            if (unit == "metric")
            {
                InputMetricHeight();
                InputMetricWeight();
                CalculateMetric();
                
            }
            else
            {
                InputImperialHeight();
                InputImperialWeight();
                CalculateImperial();
            }

            OutputBmi();
            BameMessage();
            HealthMessage();
        }

        

        private void Heading()
        {
            Console.WriteLine("Welcome to the BMI Calculator");
            Console.WriteLine("By Alex Clements");
        }

        private string SelectUnit()
        {

            Console.WriteLine("Please select metric or imperial units");
            string choice = DisplayChoices();

            string unit = ExecuteChoices(choice);
            Console.WriteLine($" You have chosen {unit}");
            return unit.ToLower();
        }
        private static string DisplayChoices()
        {
            Console.WriteLine();
            Console.WriteLine($"1. {METRIC}");
            Console.WriteLine($"2. {IMPERIAL}");

            Console.WriteLine();
            string choice = Console.ReadLine();

            return choice;
        }

        private string ExecuteChoices(string choice)
        {
            if (choice.Equals("1"))
            {
                return METRIC;


            }

            else if (choice.Equals("2"))
            {
                return IMPERIAL;
            }
            Console.WriteLine("invalid choice");
            return null;
        }

        private double InputMetricHeight()
        {
            Console.Write("Please enter your height in Centimeters >");
            string centimeters = Console.ReadLine();
            return Convert.ToDouble(centimeters);
        }

        private double InputMetricWeight()
        {
            Console.Write("Please enter your weight in Kilograms >");
            string kilograms = Console.ReadLine();
            return Convert.ToDouble(kilograms);
        }

        private double InputImperialHeight()
        {
            Console.Write("Please enter your height in Inches >");
            string inches = Console.ReadLine();
            return Convert.ToDouble(inches);
        }

        private double InputImperialWeight()
        {

            Console.Write("Please enter your weight in pounds >");
            string pounds = Console.ReadLine();
            return Convert.ToDouble(pounds);
        }


        private void CalculateImperial()
        {
            index = (pounds / (inches * inches));
        }

        private void CalculateMetric()
        {
            index = ((kilograms * 703) / (centimetres * centimetres));
        }

        private void OutputBmi()
        {
           
            
        }

         private void BameMessage()
            {
            Console.WriteLine("\n");
            Console.WriteLine(" If you are Black, Asian or other minority");
            Console.WriteLine("\n ethnic groups, you have a higher risk");
            Console.WriteLine("\n");
            Console.WriteLine("\n Adults 23.0 or more are at increased risk");
            Console.WriteLine("\n Adults 27.5 or more are at high risk");
            Console.WriteLine("\n");
             }

            private void HealthMessage()
            {

            }

        }
}

