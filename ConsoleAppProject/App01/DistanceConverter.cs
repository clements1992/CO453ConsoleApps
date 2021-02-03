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
    public class DistanceConverter
    {

        private double miles;

        private double feet;
        /// <summary>
        /// 
        /// </summary>
        public void Run()
            {
                
                Console.WriteLine();
                Console.WriteLine(" -----------------" );
                Console.WriteLine(" Convert Miles to Feet ");
                Console.WriteLine(" by Alex Clements");
                Console.WriteLine(" ------------------ ")

                InputMiles();
                CalculateFeet();
                OutputFeet();
            }
        /// <summary>
        /// 
        /// </summary>
       private void InputMiles()
            {
            Console.Write("Please enter the number of miles > ");
            string value = Console.ReadLine();
            miles = Convert.ToDouble(value);
            
            }
        /// <summary>
        /// 
        /// </summary>
        private void CalculateFeet()
            {
            feet = miles * 5280;
            }
        /// <summary>
        /// 
        /// </summary>
        private void OutputFeet()
            {
            Console.WriteLine(miles + " miles is " + feet + " feet!");
            }
    }
}
