using ConsoleAppProject;
using System;
using System.Collections.Generic;
using System.Text;


namespace ConsoleAppProject.App03
{
    /// <summary>
    /// Student Grades class, includes all varibales, arrays and methods
    /// </summary>
    public class StudentGrades
    {
        /// <summary>
        /// Constants used in the output marks method, number of students
        /// </summary>

        public const int NoStudents = 10;

        public const int LowestMark = 0;
        public const int HighestMark = 100;
        public const int LowestGradeD = 40;
        public const int LowestGradeC = 50;
        public const int LowestGradeB = 60;
        public const int LowestGradeA = 70;

        public const string GRADEPROFILE = "See the grade profile";

        /// <summary>
        /// Variables, with get and set method, all public so other classes can use them
        /// Four arrays are used
        /// </summary>
        public string[] Students;
        public int[] Marks;
        public int[] GradeProfile;
        public int[] StatsMarks;

        public double Mean { get; set; }
        public double Minimum { get; set; }
        public int Maximum { get; set; }

        public string options;

        /// <summary>
        /// Constructor for student names array
        /// </summary>
        public StudentGrades()
        {
            Students = new string[]
            {
                "Alex","Matthew","Oliver","Chris","Mark","Olivia","Marilyn","Liam","Leah","Georgia"
            };
            GradeProfile = new int[(int)Grades.A + 1];
            Marks = new int[Students.Length];
        }

        /// <summary>
        /// Methods
        /// Display menu, calls DisplayChoices to show the user the menu
        /// </summary>
        public void UserSelect()
        {
            bool carryOn = true;

            do
            {
                Console.WriteLine("Welcome to Student Grades");
                Console.WriteLine("By Alex Clements");
                Console.WriteLine("Please select from the following > ");
                string choice = DisplayChoices();

                ExecuteChoices(choice);

            } while (carryOn);

            Quit();
        }

        /// <summary>
        /// Lets the user choose which of the four methods to do
        /// </summary>
        private static string DisplayChoices()
        {
            Console.WriteLine();
            Console.WriteLine("1. Input Marks");
            Console.WriteLine("2. Output Marks");
            Console.WriteLine("3. Output Stats");
            Console.WriteLine("4. Output Grades Profile");
            Console.WriteLine("5. Quit");
            Console.WriteLine();


            Console.WriteLine();
            string choice = Console.ReadLine();

            return choice;
        }
        /// <summary>
        /// Executes the users decision
        /// </summary>
        private void ExecuteChoices(string choice)
        {
            if (choice.Equals("1"))
            {
                InputMarks();
            }

            else if (choice.Equals("2"))
            {
                OutputMarks();
            }

            else if (choice.Equals("3"))
            {
                OutputStats();
            }

            else if (choice.Equals("4"))
            {
                CalculateGradeProfile();
            }

            else if (choice.Equals("5"))
            {
                Quit();
            }
        }
        /// <summary>
        /// Quits the program
        /// </summary>
        public void Quit()
        {
            Environment.Exit(0);
        }

        /// <summary>
        /// Allows the user to input the marks for each of the ten students
        /// </summary>
        public string InputMarks()
        {
            int mark;
            int index = 0;

            ConsoleHelper.OutputTitle(" Input Student Marks >");

            foreach (string student in Students)
            {

                mark = (int)ConsoleHelper.InputNumber("Please enter a mark for  " + (student) + " > ", 0, HighestMark);
                Marks[index] = mark;
                index++;
            }

            UserSelect();
            string choice = Console.ReadLine();
            return choice;
        }

        /// <summary>
        /// Outputs the users marks for each of the ten students. student, mark, Grades. students array only has names, marks array only has marks
        /// </summary>
        public void OutputMarks()
        {
            ConsoleHelper.OutputTitle(" Listing of Student Marks >");
            for (int index = 0; index < NoStudents; index++)
            {
                Console.WriteLine($" {Students[index]} {Marks[index]}");
            }
        }

        /// <summary>
        /// Converts each mark for each student into a grade
        /// </summary>
        public Grades ConvertToGrade(int mark)
        {
            if (mark >= 0 && mark < LowestGradeD)
                return Grades.F;
            else if (mark >= LowestGradeD && mark < LowestGradeC)
                return Grades.D;
            else if (mark >= LowestGradeC && mark < LowestGradeB)
                return Grades.C;
            else if (mark >= LowestGradeB && mark < LowestGradeA)
                return Grades.B;
            else if (mark >= LowestGradeA && mark < HighestMark)
                return Grades.A;
            else
                return Grades.X;
        }


        /// <summary>
        /// Calculates the mean total for each student
        /// </summary>
        public void CalculateStats()
        {
            Minimum = Marks[0];
            Maximum = Marks[0];

            double total = 0;

            foreach (int mark in Marks)
            {
                if (mark > Maximum) Maximum = mark;
                if (mark < Minimum) Minimum = mark;
                total = total + mark;
            }
            Mean = total / Marks.Length;
        }

        /// <summary>
        /// Outputs the 3 methods inside
        /// </summary>
        public void OutputStats()
        {
            OutputMean();
            OutputMin();
            OutputMax();
        }

        /// <summary>
        /// Calculates the grade profile for each student
        /// </summary>
        public void CalculateGradeProfile()
        {
            for (int i = 0; i < GradeProfile.Length; i++)
            {
                GradeProfile[i] = 0;
            }
            foreach (int mark in Marks)
            {
                Grades grade = ConvertToGrade(mark);
                GradeProfile[(int)grade]++;
            }
            OutputGradeProfile();
        }

        /// <summary>
        /// Outputs the grade profile for each student
        /// </summary>
        private void OutputGradeProfile()
        {
            ConsoleHelper.OutputHeading("Grade Profile");
            Grades grade = Grades.X;
            Console.WriteLine();

            foreach (int count in GradeProfile)
            {
                int percentage = count * 100 / Marks.Length;
                grade++;
                Console.WriteLine($"Grade {grade} {percentage}% Count {count}");
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Outputs mean average, uses the console helper for the title
        /// </summary>
        private void OutputMean()
        {
            ConsoleHelper.OutputTitle(" The mean average mark is >");
            CalculateStats();
            Console.WriteLine($"{Mean}");
        }

        /// <summary>
        /// Outputs maximum mark, uses the console helper for the title
        /// </summary>
        private void OutputMax()
        {
            ConsoleHelper.OutputTitle(" The highest mark is >");
            CalculateStats();
            Console.WriteLine($"{Maximum}");
            Console.WriteLine();
        }


        /// <summary>
        /// Outputs lowest mark, uses the console helper for the title
        /// </summary>
        private void OutputMin()
        {
            ConsoleHelper.OutputTitle(" The lowest mark is >");
            CalculateStats();
            Console.WriteLine($"{Minimum}");
        }
    }
}

