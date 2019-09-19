using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _04_Methods
{
    [TestClass]
    public class Methods
    {
        [TestMethod]
        public void MethodExamples()
        {
            // + = - / * %

            int sum = 2 + 2;
            int subtraction = 2 - 2;
            int multiply = 2 * 2;
            int divide = 2 / 2;
            int remainder = 2 % 2;


            int expected = 8;
            int actual = AddTwoNumbers(sum, multiply);
            Assert.AreEqual(expected, actual);

            int expectedTwo = 1;
            int actualTwo = SubtractTwoNumbers(divide, remainder);
            Assert.AreEqual(expectedTwo, actualTwo);   //if one assert test fails, all tests will fail
        }

        //1 =access modifier   2 = return type  3 = method name   4 = Parentheses(parameters)

        //1    //2  //4         //4
    

        public int AddTwoNumbers(int numOne, int numTwo)
        {
            int sum = numOne + numTwo;
            return sum;
        }

        public int SubtractTwoNumbers(int numOne, int numTwo)
        {
            int subtract = numTwo - numOne;
            return subtract;
        }

        public int DivideTwoNumbers(int numOne, int numTwo)
        {
            int divide = numOne / numTwo;
            return divide;
        }

        public int MultiplyTwoNumbers(int numOne, int numTwo)
        {
            int multiply = numOne * numTwo;
            return multiply;
        }

        public int RemainderTwoNumbers(int numOne, int numTwo)
        {
            int divide = numOne % numTwo;
            return divide;
        }

    }
}
