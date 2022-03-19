using ConsoleAppProject;
using ConsoleAppProject.App02;
using System;

namespace ConsoleAppProject.App02
{
    /// <summary>
    /// Please describe the main features of this App
    /// </summary>
    /// <author>
    /// Student Name version 0.1
    /// </author>
    /// 
    public class BMI
    {
        public double weight;
        public double height;

        public void Run()
        {
            OutputHeading();
            CalcuateBMI();
        }
        public void OutputHeading()
        {
            Console.WriteLine("App 2 - BMI Calculator");
            Console.WriteLine("         by           ");
            Console.WriteLine("  Ethan Dias-Richards ");
        }

        public void CalcuateBMI()
        {
            Console.WriteLine("Please enter your weight: ");
            string weightvalue = Console.ReadLine();
            weight = Convert.ToDouble(weightvalue);

            Console.WriteLine("Please enter your height: ");
            string heightvalue = Console.ReadLine();
            height = Convert.ToDouble(heightvalue);

            double bmi = weight / height;

            Console.WriteLine("Your BMI is " + bmi);

        }
        public static void Main(String[] args)
        {
            BMI bmi = new BMI();

            bmi.OutputHeading();
            bmi.CalcuateBMI();


        }
    }

   }



