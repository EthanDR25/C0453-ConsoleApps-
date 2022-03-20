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

        // Attributes

     
        public StudentGrades()
        {
            Students = new string[]
            {
                "Ethan", "Jonathan", "Jordan", "Andrew",
                "Kevin", "Patrick", "George", "Peter",
                "Sophie", "Brian"
            };

            GradeProfile = new int[(int)Grades.A + 1];
            Marks = new int[Students.Length];

        }

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
        
        public void InputMarks()
        {

        }

        public void OutputMarks()
        {

        }

        public void CalcualteStats()
        {
         

            double total = 0;
            
            foreach(int mark in Marks)
            {
                if(mark > Minimum[0])
                {
                    Minimum[0] = mark;
                }
                if(mark < Maximum[0])
                {
                    Maximum[0] = mark;
                }
                
                total += mark;
            }

            Mean[0] = total / Marks.Length;

    

        }

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

        public void CalculateGradeProfile()
        {
            for(int i = 0; i < GradeProfile.Length; i++)
            {
                GradeProfile[i] = 0;
            }

            foreach(int mark in Marks)
            {
                Grades grade = ConvertToGrade(mark);
                GradeProfile[(int)grade]++;
            }

            OutputGradeProfile();
        }
    }
}
