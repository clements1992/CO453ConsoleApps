using ConsoleAppProject.App01;
using ConsoleAppProject.App02;
using ConsoleAppProject.App03;
using System;

namespace ConsoleAppProject
{
    /// <summary>
    /// The main method in this class is called first
    /// when the application is started.  It will be used
    /// to start Apps 01 to 05 for CO453 CW1
    /// 
    /// This Project has been modified by:
    /// Alex Clements 03/02/2021
    /// </summary>
    public static class Program
    {
        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            
            Console.WriteLine("BNU CO453 Applications Programming 2020-2021!");
            Console.WriteLine("1. Distance Converter");
            Console.WriteLine("2. BMI Calculator");
            Console.WriteLine("3. Student Grades");
            Console.WriteLine("Select your application");
            string choice = Console.ReadLine();
            

            if (choice == "1")
            {
                DistanceConverter converter = new DistanceConverter();
                converter.ConvertDistance();


            }
            else if (choice == "2")
            {
                BMICalculator converter = new BMICalculator();
                converter.Run();
            }

            else if (choice == "3")
            {
                StudentGrades converter = new StudentGrades();
                converter.UserSelect();
            }

            else Console.WriteLine("Invalid choice");
        }
    }
}
