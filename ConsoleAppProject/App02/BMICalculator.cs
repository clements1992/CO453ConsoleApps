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

        public double index;
        public string who;

        public double centimetres;
        public double inches;
        public double kilograms;
        public double metres;
        public double pounds;
        public double stone;
        public double bmi;

        public void Run()
        {

            Heading();
            string unit = SelectUnit();


            if (unit == "metric")
            {
                centimetres = InputMetricHeight();
                kilograms = InputMetricWeight();
                CalculateMetric();


            }
            else
            {
                inches = InputImperialHeight();
                pounds = InputImperialWeight();
                CalculateImperial();

            }

            OutputBmi();
            CalculateWho();
            OutputWho();
            OutputWarning();
        }



        private void Heading()
        {
            Console.WriteLine("Welcome to the BMI Calculator");
            Console.WriteLine("By Alex Clements");
        }

        private string SelectUnit()
        {

            Console.WriteLine("Please select metric or imperial units > ");
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
            Console.Write("Please enter your height in Centimeters > ");
            string value = Console.ReadLine();
            return Convert.ToDouble(value);
        }

        private double InputMetricWeight()
        {
            Console.Write("Please enter your weight in Kilograms > ");
            string value = Console.ReadLine();
            return Convert.ToDouble(value);
        }

        private double InputImperialHeight()
        {
            Console.Write("Please enter your height in Inches > ");
            string value = Console.ReadLine();
            return Convert.ToDouble(value);
        }

        private double InputImperialWeight()
        {

            Console.Write("Please enter your weight in pounds > ");
            string value = Console.ReadLine();
            return Convert.ToDouble(value);
        }


        private void CalculateImperial()
        {
            index = (double)pounds * 703 / (inches * inches);
        }

        private void CalculateMetric()
        {
            index = (kilograms / (metres * metres));
        }

        private void OutputBmi()
        {
            Console.WriteLine($"Your BMI is {index:0.00}");
        }

        private void CalculateWho()
        {
            if (index < 18.5)
            {
                who = "underweight";
            }
            else if (index >= 18.5 && index <= 24.9)
            {
                who = "healthy";
            }
            else if (index >= 25.0 && index <= 29.9)
            {
                who = "overweight";
            }
            else if (index >= 30.0 && index <= 34.9)
            {
                who = "obese level 1";
            }
            else if (index >= 35.0 && index <= 39.9)
            {
                who = "obese level 2";
            }
            else if (index >= 40.0)
            {
                who = "obese level 3";
            }
        }

        private void OutputWho()
        {
            Console.WriteLine("You are classed as being" + who);
        }

        private void OutputWarning()
        {
            Console.WriteLine("\n");
            Console.WriteLine(" If you are Black, Asian or other minority ethnic groups, you have a higher risk");
            Console.WriteLine("\n");
            Console.WriteLine("\n Adults 23.0 or more are at increased risk");
            Console.WriteLine("\n");
            Console.WriteLine("\n Adults 27.5 or more are at high risk");
            Console.WriteLine("\n");
        }

    }
}

