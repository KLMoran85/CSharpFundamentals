using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _03_loops
{
    [TestClass]
    public class Loops
    {
        [TestMethod]
        public void ForLoops()
        {
            int studentCount = 13;

            for (int i = 0; i<studentCount; i++) 
            {
                Console.WriteLine(i);
                studentCount--;
            }

            for (int i = studentCount; i >= 1; i--)
            {
                Console.WriteLine(i);
            }

            for (int i = 0; i < studentCount--; i++)
            {
                Console.WriteLine(i);
            }
        }

        [TestMethod]
        public void WhileLoops()
        {
            int number = 5;
            bool something = false;
            while (!something) //is not equal to 6  *if our int number was 7, it would be infinite loop
            {
                Console.WriteLine(number);
                number++;
                something = true;
            }
        }

        [TestMethod]
        public void ForEachLoops()
        {
            List<string> students = new List<string>();

            students.Add("Regan");
            students.Add("Paul");
            students.Add("Ben");
            students.Add("Aaron");
            students.Add("Erick");

            foreach(string studentName in students)
            {
                Console.WriteLine(studentName);
            }

            string mountainName = "Mauna Kea";
            foreach (char letter in mountainName)  //variable names are always camel cased
            {
                if (letter == 'a')
                {
                    Console.WriteLine(letter);
                }
            }
           

           
        }
    }

}
