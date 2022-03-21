using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using ConsoleAppProject.Helpers;

namespace ConsoleAppProject.App03
{
    /// <summary>
    /// At the moment this class just tests the
    /// Grades enumeration names and descriptions
    /// </summary>
    public class StudentGrades
    {
        // Constants
        public const int LowestMark = 0;
        public const int LowestGradeD = 40;
        public const int LowestGradeC = 50;
        public const int LowestGradeB = 60;
        public const int LowestGradeA = 70;
        public const int HighestMark = 100;

        // Properties
      public string[] Students { get; set; }
      public int[] Marks { get; set; }
      public int[] GradeProfile { get; set; }
      public double[] Mean { get; set; }
      public int[] Minimum { get; set; }
      public int[] Maximum { get; set; }
      public int Total { get; set; }

        // Attributes

        // Run the app
        public void Run()
        {
            ConsoleHelper.OutputHeading("App 3 - Grades");
            InputMarks();
            OutputGrades();
            CalcualteStats();
            CalculateGradeProfile();
        }
        public StudentGrades()
        {
            Students = new string[]
            {
                "Jonathan", "Gareth", "Jordan", "Andrew",
                "Kevin", "Patrick", "George", "Peter",
                "Sophie", "Brian"
            };

            GradeProfile = new int[(int)Grades.A + 1];
            Marks = new int[Students.Length];

        }

        // Grades Conversion
        public Grades ConvertToGrade(int mark)
        {
            if (mark >= LowestMark && mark < LowestGradeD)
            {
                return Grades.F;
            }
            else if(mark >= LowestGradeD && mark < LowestGradeC)
            {
                return Grades.D;
            }
            else if(mark >= LowestGradeC && mark < LowestGradeB)
            {
                return Grades.C;
            }
            else if(mark >= LowestGradeB && mark < LowestGradeA)
            {
                return Grades.B;
            }
            else if(mark >= LowestGradeA && mark < HighestMark)
            {
                return Grades.A;
            }

            return Grades.F;

        }
        
        //Entering a mark for each student
        public void InputMarks()
        {
            Console.WriteLine("Please enter a mark for each student\n");

            int index = 0;

            foreach (string name in Students)
            {
                int mark = (int)ConsoleHelper.InputNumber($" {name} Enter mark: ", 0, 100);
                Marks[index] = mark;
            }
        }

        public void OutputMarks()
        {
            for(int i = 0; i < Marks.Length; i++)
            {
                Console.WriteLine($"{Students[i]} mark = {Marks[i]}");
            }
        }

        // Calculating the Mean, Minimum and Maximim
        public void CalcualteStats()
        {
            int Minimum = Marks[0];
            int Maximum = Marks[0];

           
            
            foreach(int mark in Marks)
            {
                if(mark > Maximum) Maximum = mark;
                if(mark < Minimum) Minimum = mark;
                Total += mark;
            }

            double Mean = Total / Marks.Length;

            Console.WriteLine("");
            Console.WriteLine($"Mean = {Mean} Minimum = {Minimum} Maximum = {Maximum}");

        }

        public void OutputGrades()
        {
            for(int i = 0; i < Marks.Length; i++)
            {
                int mark = Marks[i];
                Grades grade = ConvertToGrade(mark);
                Console.WriteLine($"{Students[i]} mark = {Marks[i]} Grade = {grade}");
            }


        }

        // Displaying the Grade Profile
        public void OutputGradeProfile()
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
        // Calculating the Grade Profile
        public void CalculateGradeProfile()
        {
            
            foreach(int mark in Marks)
            {
                Grades grade = ConvertToGrade(mark);
                GradeProfile[(int)grade]++;
            }

            OutputGradeProfile();
        }
    }
}
