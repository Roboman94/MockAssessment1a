using System;
using System.Linq;

namespace MockAssessment1a
{
    class Program
    {
        static void Main(string[] args)
        {
            bool proceeding = true;
            while (proceeding == true)
            {
                Console.WriteLine("Hello! Welcome to building proportion grader!");
                double num1 = IntPar("Please enter the width of the building");
                double num2 = IntPar("Please enter the height of the building");

                if (IsTheSame(num2, num1))
                {
                    Console.WriteLine("The building is a box..?");
                }
                else
                {
                    num2 = Subtract(num1, num2);

                    string result = FindBuildingType(num2);
                    Console.WriteLine(result);
                }


                //fin?
                proceeding = Proceed();
            }
        }

        public static double IntPar(string numx)
        {
            string input = " ";
            int validcheck = 1;
            while (validcheck == 1)
            {
                Console.WriteLine(numx);
                input = Console.ReadLine();

                if (input.All(char.IsNumber))
                {
                    validcheck = 0;
                }
                else
                {
                    validcheck = 1;
                    Console.WriteLine("Invalid entry. Please try again.");
                }
            }
            double num1 = double.Parse(input);
            return num1;
        }

        public static bool IsTheSame(double num1, double num2)
        {
            if (num1 == num2) {
               return true; 
            }
           
                return false;
            

}

        public static double Subtract(double num1, double num2)
        {
            num2 = num2 - num1;
            return num2;
        }

        public static string FindBuildingType(double num2)
        {
            if(num2 > 50){
                return "This is a SUPER skyscraper!";
            }
            if(num2 <= 3){
                return "This is a house!";
            }
            if (num2 >= 4 && num2 <= 10)
            {
                return "This is and office building!";
            }
            if(num2 >= 11 && num2 <= 49){
                return "This is a skyscraper!";
            }
            return "error please try again";

        }

        public static bool Proceed()
        {
            Console.WriteLine();
            Console.WriteLine("Would you like to continue? (y/n) ");
            string proceed = Console.ReadLine().ToLower();
            if (proceed.ToLower().StartsWith("y"))
            {
                return true;
            }
            if (proceed.ToLower().StartsWith("n"))
            {
                Console.WriteLine("thank you!");
                Console.WriteLine();
                return false;
            }
            else
            {
                Console.WriteLine("Invalid entry. Please try again");
                return Proceed();
            }
         }

    }
}

