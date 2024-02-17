using System;

namespace CISS222_Homework3
{
    class Program
    {
        public static void Main(string[] args)
        {
            // You will need to find the file in the Solution Explorer called BasicArithmetic.cs
            // In that file, you will find four methods:
            //  Sum
            //  Difference
            //  Product
            //  QuotientWithRemainder
            // In each of those methods, you will implement the appropriate mathematical function.
            // In this Main() method, you will get the user input, and then you will call the method
            // to perform the calculation. The actual mathematical operations should only be performed
            // in the methods in the BasicArithmetic file; do not do the math here.

            // You will call each method in a manner similar to below:

            // var result = BasicArithmetic.Sum(the variable that you will use to collect input from the user);

            // You will take the output from each of the methods and display them per the screenshots in GitHub

            // Next, you will implement a new method in the BasicArithmetic file based on the mathematical operation you selected

            //Variable for input 

            string inputFirstNumber = "";
            string inputSecondNumber = "";
            int myFirstNumber = 0;
            int mySecondNumber = 0;
            //Gets input from user
            Console.WriteLine("Please enter first number");
            inputFirstNumber = Console.ReadLine();
            Console.WriteLine("Please enter second number");
            inputSecondNumber = Console.ReadLine();
            int.TryParse(inputFirstNumber, out myFirstNumber);
            int.TryParse(inputSecondNumber, out mySecondNumber);
            //Output results for each method 
            var resultOne = BasicArithmetic.Sum(myFirstNumber, mySecondNumber);
            Console.WriteLine("Sum of first number " + myFirstNumber + " and second number " + mySecondNumber + " is " + resultOne);
            Console.WriteLine();

            var resultTwo=BasicArithmetic.Difference(myFirstNumber, mySecondNumber);
            Console.WriteLine("Difference of first number " + myFirstNumber + " and second number " + mySecondNumber + " is " + resultTwo);
            Console.WriteLine();
            
            var resultThree=BasicArithmetic.Product(myFirstNumber, mySecondNumber);
            Console.WriteLine("Product of first number " + myFirstNumber + " and second number " + mySecondNumber + " is " + resultThree);
            Console.WriteLine();

            var resultFour= BasicArithmetic.QuotientWithRemainder(myFirstNumber, mySecondNumber);
            Console.WriteLine("Quotient of first number " + myFirstNumber + " and second number " + mySecondNumber + " is " + resultFour);
            Console.WriteLine();

            var resultFive= BasicArithmetic.Power(myFirstNumber, mySecondNumber);
            Console.WriteLine("Power of first number " + myFirstNumber + " and second number " + mySecondNumber + " is " + resultFive);
            Console.WriteLine();

        }
    }
}