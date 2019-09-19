using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _02_Conditionals
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void IfElseStatements()
        {
            // if else if else   // ctrl shift l cleans up white spaces

            int age = 14;

            if (age >= 21)
            {
                Console.WriteLine("You can drink!");
            }
            else if (age < 21)
            {
                Console.WriteLine("Sorry");
                age += 4;
            }

            else
            {
                Console.WriteLine("This is default.");
            }

            if(age == 18)
            {
                Console.WriteLine("You wrote me out.  YAY");
            }

            decimal bankAccount = 100m;
            
            if(bankAccount <5)
            {
                Console.WriteLine("You need more money.");
            }
            else if(bankAccount >=5 && bankAccount < 100)
            {
                Console.WriteLine("Movig up in the world.");
            }
            else if(bankAccount == 100 || bankAccount == 4)
            {
                Console.WriteLine("Whoa!");
            }
            else
            {
                Console.WriteLine("Cool!");
            }

            //&& == AND || == OR > < >= <= !=
        }

        [TestMethod]
        public void SwitchCases()
        {
            int age = 6;
            switch (age)
            {
                case 1:
                    //The code we want to execute //if we want to execute the same code for each case, delete the breaks
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    Console.WriteLine("Happy Birthday");
                    break;
                case 5:
                    break;
                default:
                    Console.WriteLine("Too bad. It will be soon.");
                    break;
            }
        }

        [TestMethod]
        public void Ternaries()
        {
            int age = 55;

            // 1condition   // 2 if true  3 //if false
            //1   //2   //3  
            //() ? true : false;

            bool isAdult = age > 18 ? true : false;
        }

     }   
}
