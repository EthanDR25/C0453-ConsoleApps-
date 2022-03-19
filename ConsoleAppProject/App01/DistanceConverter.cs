using ConsoleAppProject.App01;
using System;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// Please describe the main features of this App
    /// <summary>
    /// <author>
    /// Derek version 0.1
    /// </author>
    public class DistanceConverter
    {
        public const int FEET_IN_MILES = 5280;
        public const double METRES_IN_MILES = 1609.34;
        public const double FEET_IN_METRES = 3.28084;

        private double miles;

        private double feet;

        private string number;

        private double metres;

        public const string FEET = "feet";

        public const string METRES = "metres";

        public const string MILES = "miles";

        private double fromDistance;

        private double toDistance;

        private string fromUnit;

        private string toUnit;

        public DistanceConverter()
        {
            fromUnit = MILES;
            toUnit = FEET;
        }

        public DistanceUnits DistanceUnits
        {
            get => default;
            set
            {
            }
        }

        /// <summary>
        /// This method will output a heading, ask for the
        /// input for miles, calculate and output the same
        /// distance in feet.
        /// </summary>
        public void Run()
        {
            OutputHeading();
            SelectUnit("");
            CalculateDistance();
            OutputDistance();
        }
        /// <summary>
        /// This is the method for outputting the heading
        /// </summary>
        public static void OutputHeading()
        {
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine();
            Console.WriteLine(" ========================");
            Console.WriteLine("    Distance Converter   ");
            Console.WriteLine("  by Ethan Dias-Richards ");
            Console.WriteLine(" ========================");
            Console.WriteLine();
        }

        

        private void CalculateDistance()
        {
            if(fromUnit == MILES && toUnit == FEET)
            {
                toDistance = fromDistance * FEET_IN_MILES;
            }
            else if(fromUnit == FEET && toUnit == MILES)
            {
                toDistance = fromDistance / FEET_IN_MILES;
            }
            else if (fromUnit == METRES && toUnit == FEET)
            {
                toDistance = fromDistance * FEET_IN_METRES;
            }
            else if (fromUnit == FEET && toUnit == METRES)
            {
                toDistance = fromDistance / METRES_IN_MILES;
            }
            else if (fromUnit == METRES && toUnit == MILES)
            {
                toDistance = fromDistance / METRES_IN_MILES;
            }
            else if (fromUnit == MILES && toUnit == METRES)
            {
                toDistance = fromDistance * METRES_IN_MILES;
            }
        }
        public void ConvertDistance()
        {
            OutputHeading();
            fromUnit = SelectUnit("Please select the from distance unit: ");
            toUnit = SelectUnit("Please select the to distance unit: ");

           
            fromDistance = InputDistance($"Please enter the number of {fromUnit}: ");

            OutputDistance();
        }
      
        /// <summary>
        /// This is the method for converting feet to metres
        /// </summary>
        /// 
       

        private void OutputDistance()
        {
            Console.WriteLine($" {fromDistance} {fromUnit} is {toDistance} {toUnit}");
        }

        public string SelectUnit(string prompt)
        {
            String choice = DisplayChoices(prompt);

            string unit = ExecuteChoice(choice);

            Console.WriteLine($"\nYou have chosen {unit}");

            return unit;
            
        }

        private static string DisplayChoices(string prompt)
        {
            Console.WriteLine();
            Console.WriteLine($" 1. {FEET}");
            Console.WriteLine($" 2. {METRES}");
            Console.WriteLine($" 3. {MILES}");

            Console.WriteLine(prompt);
            string choice = Console.ReadLine();
            return choice;
        }

        private static string ExecuteChoice(string choice)
        {
            if(choice.Equals("1"))
            {
                return FEET;
            }
            else if(choice.Equals("2"))
            {
                return METRES;
            }
            else if(choice.Equals("3"))
            {
                return MILES;
            }

            return null;
        }
        private double InputDistance(string prompt)
        {
            Console.WriteLine(prompt);
            string value = Console.ReadLine();
            return Convert.ToDouble(value);
        }
        
    }
}







