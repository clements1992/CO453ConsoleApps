﻿using System;


namespace ConsoleAppProject.App03
{
    public class StudentGrades
    {

        // Constants

        public const int LowestMark = 0;
        public const int HighestMark = 100;
        public const int LowestGradeD = 40;
        public const int LowestGradeC = 50;
        public const int LowestGradeB = 60;
        public const int LowestGradeA = 70;
        public string[] Students { get; set; }
        public int[] Marks { get; set; }
        public int[] GradeProfile { get; set; }
        public double Mean { get; set; }
        public double[] Minimum { get; set; }
        public int[] Maximum { get; set; }

        //Constructor for student names//
        public StudentGrades()
        {
            Students = new string[]
            {
                "Alex","Matthew","Oliver","Chris","Mark","Olivia","Marilyn","Liam","Leah","Georgia"
            };
            GradeProfile = new int[(int)Grades.A + 1];
            Marks = new int[Students.Length];
        }

        // Methods


        public string UserSelect()
        {
            Console.WriteLine("Welcome to Student Grades");
            Console.WriteLine("By Alex Clements");
            Console.WriteLine("Please select from the following > ");
            string choice = DisplayChoices();

            string unit = ExecuteChoices(choice);
            Console.WriteLine($" You have chosen {unit}");
            return unit.ToLower();
        }
        private static string DisplayChoices()
        {
            Console.WriteLine();
            Console.WriteLine("1. Input Marks");
            Console.WriteLine("2. Output Marks");
            Console.WriteLine("3. Output Stats");
            Console.WriteLine("4. Outout Grades Profile");


            Console.WriteLine();
            string choice = Console.ReadLine();

            return choice;
        }

        private string ExecuteChoices(string choice)
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
                OutputMarks();
            }

            else if (choice.Equals("4"))
            {
                OutputGradeProfile();
            }

            Console.WriteLine("invalid choice");
            return null;
        }

        public void InputMarks()
        {
            throw new NotImplementedException();
        }

        public void OutputMarks()
        {
            throw new NotImplementedException();
        }

        public Grades ConvertToGrade(int mark)
        {
            if (mark >= LowestMark && mark < LowestGradeD)
            {
                return Grades.F;
            }
            else if (mark >= LowestMark && mark < LowestGradeC)
            {
                return Grades.D;
            }
            else if (mark >= LowestMark && mark < LowestGradeB)
            {
                return Grades.C;
            }
            else if (mark >= LowestMark && mark < LowestGradeB)
            {
                return Grades.C;
            }
            else if (mark >= LowestMark && mark < LowestGradeA)
            {
                return Grades.B;
            }
            else
            {
                return Grades.A;
            }
        }

        public void CalculateStats()
        {
            double total = 0;

            foreach(int mark in Marks)
            {
                total = total + mark;
            }
            Mean = total / Marks.Length;
        }

        
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
        }

        private void OutputGradeProfile()
        {
            Grades grade = Grades.X;
            Console.WriteLine();

            foreach(int count in GradeProfile)
            {
                int percentage = count * 100 / Marks.Length;
                Console.WriteLine($"Grade {grade} {percentage}% Count {count}");
                grade++;
            }

            Console.WriteLine();
        }
    }

}


