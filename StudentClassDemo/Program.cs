//Patrik Sullivan psullivan8@cnm.edu
//StudentClassDemo 05/28/20

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentClassDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string doAnother;
            do
            {
                Student st = new Student();
                string studentFirstName = GetInput("First Name: ");
                st.SetFirstName(studentFirstName);
                string studentLastName = GetInput("Last Name: ");
                st.SetLastName(studentLastName);
                string major = GetInput("Major: ");
                st.SetMajor(major);
                string studentNum = GetInput("Student Number: ");
                st.SetStudentNumber(studentNum);
                int score1 = int.Parse(GetInput("Score 1: "));
                st.SetScore1(score1);
                int score2 = int.Parse(GetInput("Score 2: "));
                st.SetScore2(score2);
                int score3 = int.Parse(GetInput("Score 3: "));
                st.SetScore3(score3);

                Console.WriteLine(st.GetSummary());

                doAnother = GetInput("\nDo another? (y/n)");
            } while (doAnother == "y");
        }
        private static string GetInput(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine();
        }
    }
}