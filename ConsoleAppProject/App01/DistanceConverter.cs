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

            }
        /// <summary>
        /// 
        /// </summary>
        private void OutputFeet()
            {

            }
    }
}
