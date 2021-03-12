using ConsoleAppProject;
using System;


namespace ConsoleAppProject.App03
{
    public class StudentGrades
    {

        // Constants
        // Used in the output marks method, number of students
        public const int NoStudents = 10;

        public const int LowestMark = 0;
        public const int HighestMark = 100;
        public const int LowestGradeD = 40;
        public const int LowestGradeC = 50;
        public const int LowestGradeB = 60;
        public const int LowestGradeA = 70;
        private bool index;

        // Variables, with get and set method, all public so other classes can use them
        // Four arrays are used
        public string[] Students { get; set; }
        public int[] Marks { get; set; }
        public int[] GradeProfile { get; set; }
        public int[] StatsMarks;

        public double Mean { get; set; }
        public double Minimum { get; set; }
        public int Maximum { get; set; }

        public string options;


        //Constructor for student names array
        public StudentGrades()
        {
            Students = new string[10]
            {
                "Alex","Matthew","Oliver","Chris","Mark","Olivia","Marilyn","Liam","Leah","Georgia"
            };
            GradeProfile = new int[(int)Grades.A + 1];
            Marks = new int[Students.Length];
        }

        // Methods

        // Display menu, calls DisplayChoices to show the user the menu
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

        // Lets the user choose which of the four methods to do
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

        // Executes the users decision
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
                OutputGradeProfile();
            }

            else if (choice.Equals("5"))
            {
                Quit();
            }
        }

        // Quits the program
        public void Quit()
        {
            Environment.Exit(0);
        }

        // Allows the user to input the marks for each of the ten students
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

        // Outputs the users marks for each of the ten students
        // student, mark, Grades. students array only has names, marks array only has marks
        public void OutputMarks()
        {
            ConsoleHelper.OutputTitle(" Listing of Student Marks >");
            for (int index = 0; index < NoStudents; index++)
            {
                Console.WriteLine($" {Students[index]} {Marks[index]}");
            }
        }

        // Converts each mark for each student into a grade
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

        // Calculates the mean total for each student
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

        // outputs the 3 methods inside
        public void OutputStats()
        {
            OutputMean();
            OutputMin();
            OutputMax();
        }

        // Calculates the grade profile for each student
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


        // Outputs the grade profile for each student
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


        // Outputs mean average, uses the console helper for the title
        private void OutputMean()
        {
            ConsoleHelper.OutputTitle(" The mean average mark is >");
            CalculateStats();
            Console.WriteLine($"{Mean}");
        }

        // Outputs maximum mark, uses the console helper for the title
        private void OutputMax()
        {
            ConsoleHelper.OutputTitle(" The highest mark is >");
            CalculateStats();
            Console.WriteLine($"{Maximum}");
            Console.WriteLine();
        }

        // Outputs lowest mark, uses the console helper for the title
        private void OutputMin()
        {
            ConsoleHelper.OutputTitle(" The lowest mark is >");
            CalculateStats();
            Console.WriteLine($"{Minimum}");
        }
    }
}

