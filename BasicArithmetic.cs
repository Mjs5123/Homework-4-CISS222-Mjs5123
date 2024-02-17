using System;

namespace CISS222_Homework3
{
    public static class BasicArithmetic
    {
        public static int Sum(int firstNumber, int secondNumber)
        {
            int result = firstNumber + secondNumber;
            return result;
            throw new System.NotImplementedException();
        }

        public static int Difference(int firstNumber, int secondNumber)
        {
            int result = firstNumber - secondNumber;
            return result;
            throw new System.NotImplementedException();
        }

        public static int Product(int firstNumber, int secondNumber)
        {
            int result = firstNumber * secondNumber;
            return result;
            throw new System.NotImplementedException();
        }

        public static string QuotientWithRemainder(int firstNumber, int secondNumber)
        {
            int result = firstNumber % secondNumber;
            string myResult = "";
            myResult = result.ToString();
            return myResult;
            throw new System.NotImplementedException();

        }

        public static double Power(int firstNumber, int secondNumber)
        {
            double result = Math.Pow(firstNumber, secondNumber);
            return result;
            throw new System.NotImplementedException();
        }
    }
}
