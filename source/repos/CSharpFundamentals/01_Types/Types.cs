using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _01_Types
{
    [TestClass]
    public class Types
    {
        [TestMethod]
        public void ValueTypes()
        {
            int number = 1234;
            bool on = true;
            bool off = true;

            decimal hello = 1233489789.00m;
            float anotherDecimal = 142.5f;
            double anotheranotherDecimal = 12456.56d;

            char character = '?';

            // int, double, decimal, long, short, float

            byte byteExample = 255; // 0 - 255
            sbyte sByteMax = -128;
            short shortExample = 32000;
            Int16 anotherShortExample = 32000;
            int intMin = -214748648;
            Int32 intMax = 2147483647;
            long longExample = 9223372036854775807;
            Int64 longMin = -9223372036854775808;

            float floatExample = 1.04523f;
            double doubleExample = 1.234912319d;


         }

        [TestMethod]
        public void Operators()
        {
            // + - / % *

            int numberOne = 3;
            int numberTwo = 5;

            int sum = numberOne + numberTwo;
            Console.WriteLine(sum);
             
            int numberThree = 16;
            int numberFour = 4;
            int numberFive = 7;

            int subtraction = numberThree - numberFour;
            int division = numberThree / numberFour;
            int multiply = numberThree * numberFour;
            int remainder = numberThree % numberFive;

            Console.WriteLine(subtraction);
            Console.WriteLine(division);
            Console.WriteLine(multiply);
            Console.WriteLine(remainder);


                       
        }

        [TestMethod]
        public void ReferenceTypes()
        {
            string firstName = "Katie";
            string lastName = "Moran";

            // Concatanation
            string concatanation = firstName + " " + lastName;
            Console.WriteLine(concatanation);

            // Composite Formatting
            string composite = string.Format("Hello, my name is {0} {1}", firstName, lastName);
            Console.WriteLine(composite);

            // String Interpolation
            string interpolation = $"{firstName} {lastName}";
            Console.WriteLine(interpolation);

            // Classes (objects in the program

            // Structs

            // Collections

            List<string> myList = new List<string>();
            myList.Add("Hello World");

            List<int> myNumberList = new List<int>();
            myNumberList.Add(2);

            Queue<string> myQueue = new Queue<string>();  // queue operates on first in and first out
            myQueue.Enqueue("Hello World!");

            Dictionary<int, string> myDictionary = new Dictionary<int, string>();      // Queue expects key (int) and a value (string)

            Stack<int> newStack = new Stack<int>();  //last in, last out

            string banana = "Fruit";
            string[] stringArray = {"Hello", "Character", "Food", "water"};  //We'll be mainly using lists, queues, and dictionaries



        }

        
    }
}
