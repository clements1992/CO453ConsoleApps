﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleAppProject.App03;

namespace ConsoleApp.Tests
{
    [TestClass]
    public class TestStudentGrades
    {
        private readonly StudentGrades converter = new StudentGrades();

        private int[] testMarks;
        private int[] statsMarks;


        public TestStudentGrades()
        {
            testMarks = new int[]
        {
            10, 20, 30, 40, 50, 60, 70, 80, 90, 100
        };


            statsMarks = new int[]
                {
                10,20,30,40,50,60,70,80,90,100
            };            
            }

        [TestMethod]
        public void TestConvert0ToGradeF()
        {
            // Arrange

            Grades expectedGrade = Grades.F;

            // Act

            Grades actualGrade = converter.ConvertToGrade(0);

            // Assert

            Assert.AreEqual(expectedGrade, actualGrade);
        }

        [TestMethod]
        public void TestConvert39ToGradeF()
        {
            // Arrange

            Grades expectedGrade = Grades.F;

            // Act

            Grades actualGrade = converter.ConvertToGrade(39);

            // Assert

            Assert.AreEqual(expectedGrade, actualGrade);
        }

        [TestMethod]
        public void TestConvert40ToGradeD()
        {
            // Arrange

            Grades expectedGrade = Grades.D;

            // Act

            Grades actualGrade = converter.ConvertToGrade(40);

            // Assert

            Assert.AreEqual(expectedGrade, actualGrade);
        }

        [TestMethod]
        public void TestConvert49ToGradeD()
        {
            // Arrange

            Grades expectedGrade = Grades.D;

            // Act

            Grades actualGrade = converter.ConvertToGrade(49);

            // Assert

            Assert.AreEqual(expectedGrade, actualGrade);
        }

        [TestMethod]
        public void TestConvert50ToGradeC()
        {
            // Arrange

            Grades expectedGrade = Grades.C;

            // Act

            Grades actualGrade = converter.ConvertToGrade(50);

            // Assert

            Assert.AreEqual(expectedGrade, actualGrade);
        }

         [TestMethod]
        public void TestConvert59ToGradeC()
        {
            // Arrange

            Grades expectedGrade = Grades.C;

            // Act

            Grades actualGrade = converter.ConvertToGrade(59);

            // Assert

            Assert.AreEqual(expectedGrade, actualGrade);
        }

        [TestMethod]
        public void TestConvert60ToGradeB()
        {
            // Arrange

            Grades expectedGrade = Grades.B;

            // Act

            Grades actualGrade = converter.ConvertToGrade(60);

            // Assert

            Assert.AreEqual(expectedGrade, actualGrade);
        }

        [TestMethod]
        public void TestConvert69ToGradeB()
        {
            // Arrange

            Grades expectedGrade = Grades.B;

            // Act

            Grades actualGrade = converter.ConvertToGrade(69);

            // Assert

            Assert.AreEqual(expectedGrade, actualGrade);
        }

        [TestMethod]
        public void TestConvert70ToGradeA()
        {
            // Arrange

            Grades expectedGrade = Grades.A;

            // Act

            Grades actualGrade = converter.ConvertToGrade(70);

            // Assert

            Assert.AreEqual(expectedGrade, actualGrade);
        }

        [TestMethod]
        public void TestConvert100ToGradeA()
        {
            // Arrange

            Grades expectedGrade = Grades.A;

            // Act

            Grades actualGrade = converter.ConvertToGrade(100);

            // Assert

            Assert.AreEqual(expectedGrade, actualGrade);
        }



        [TestMethod]
         public void TestCalculateMean()
        {
            converter.Marks = testMarks;
            double expectedMean = 55.0;
            converter.CalculateStats();

            Assert.AreEqual(expectedMean, converter.Mean);
        }

        [TestMethod]
        public void TestGradeProfile()
        {
            // Arrange
            converter.Marks = testMarks;

            // Act

            converter.CalculateGradeProfile();

            bool expectedProfile;
            expectedProfile = ((converter.GradeProfile[0] == 3) &&
                (converter.GradeProfile[1] == 1) &&
                (converter.GradeProfile[2] == 1) &&
                (converter.GradeProfile[3] == 1) &&
                (converter.GradeProfile[4] == 4));

            // Assert

            Assert.IsTrue(expectedProfile);
        }

        [TestMethod]
        public void TestCalculateMin()
        {
            converter.Marks = statsMarks;
            int expectedMin = 10;

            converter.CalculateStats();

            Assert.AreEqual(expectedMin, converter.Minimum);
        }

        [TestMethod]
        public void TestCalculationMean()
        {

            converter.Marks = testMarks;
            double expectedMean = 55.0;
            converter.CalculateStats();

            Assert.AreEqual(expectedMean, converter.Mean);
        }

        [TestMethod]
        public void TestCalculateMax()
        {
            converter.Marks = statsMarks;
            int expectedMax = 100;

            converter.CalculateStats();

            Assert.AreEqual(expectedMax, converter.Maximum);
        }
    }

 

}
