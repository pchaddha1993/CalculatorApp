using System;

namespace CalculatorApp
{
    public class Calc
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the function to be performed");
            Console.WriteLine("1 = Addition");
            Console.WriteLine("2 = Subtraction");
            Console.WriteLine("3 = Multiplication");
            Console.WriteLine("4 = Division \n");
            int function = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 1st Number");
            double number1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter 2nd Number");
            double number2 = Convert.ToDouble(Console.ReadLine());
            double res = 0;
            switch (function)
            {
                case 1:
                    {
                        res = Addition(number1, number2);
                        break;
                    }
                case 2:
                    {
                        res = Subtraction(number1, number2);
                        break;
                    }
                case 3:
                    {
                        res = Multiplication(number1, number2);
                        break;
                    }
                case 4:
                    {
                        res = Division(number1, number2);
                        break;
                    }
                default:
                    Console.WriteLine("Invalid Function!");
                    break;
            }
            Console.WriteLine("The result is {0}", res);
            Console.ReadKey();
        }


        //Addition  
        public static double Addition(double number1, double number2)
        {
            double result = number1 + number2;
            return result;
        }
        //Substraction  
        public static double Subtraction(double number1, double number2)
        {
            double result = number1 - number2;
            return result;
        }
        //Multiplication  
        public static double Multiplication(double number1, double number2)
        {
            double result = number1 * number2;
            return result;
        }
        //Division  
        public static double Division(double number1, double number2)
        {
            try
            {
                double result = number1 / number2;
                return result;
            }
            catch (DivideByZeroException)
            {
                return (0);
            }
        }

    }
}
