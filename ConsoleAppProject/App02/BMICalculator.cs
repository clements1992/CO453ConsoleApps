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
            SelectUnit();

            if (SelectUnit == SelectUnit.METRIC)
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

            Console.WriteLine("Health Message");
            Console.WriteLine("BAME Message");
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
            return unit;
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

      //  private void OutputBmi()
     //   {
     //       if{
      //          bmi is IMPERIAL, output imperial bmi

     //       }

     //       else if {

     //           bmi is METRIC, output metric bmi
     //       }
        }

        
        
    }
}
