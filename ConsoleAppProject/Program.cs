using ConsoleAppProject.App01;
using ConsoleAppProject.App02;
using ConsoleAppProject.App03;
using ConsoleAppProject.Helpers;
using System;

namespace ConsoleAppProject
{
    /// <summary>
    /// The main method in this class is called first
    /// when the application is started.  It will be used
    /// to start App01 to App05 for CO453 CW1
    /// 
    /// This Project has been modified by:
    /// Derek Peacock 05/02/2022
    /// </summary>
    public static class Program
    {
        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine();
            Console.WriteLine(" =================================================");
            Console.WriteLine("        BNU CO453 Applications Programming        ");
            Console.WriteLine("                by Ethan Dias-Richards            ");
            Console.WriteLine(" =================================================");
            Console.WriteLine();

            Console.WriteLine("1 - Distance Converter");
            Console.WriteLine("2 - BMI Calculator");
            Console.WriteLine("3 - Grades");
            Console.WriteLine();
            string[] choices =
            {
              "App 1 - Distance Converter",
              "App 2 - BMI Calculator",
              "App 3 - Grades"
            };

            Console.WriteLine("Please choose your app: ");
            string choice = Console.ReadLine();

          if(choice == "1")
            {
                DistanceConverter app1 = new DistanceConverter();
                app1.Run();
            }
          else if(choice == "2")
            {
                BMI app2 = new BMI();
                app2.Run();
            }
          else if(choice == "3")
            {
                StudentGrades app3 = new StudentGrades();
                app3.Run();
            }
           

           
            
        }
    }
}
