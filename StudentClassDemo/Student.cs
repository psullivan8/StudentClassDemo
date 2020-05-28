﻿//Patrik Sullivan psullivan8@cnm.edu
//StudentClassDemo 05/28/20

using System;
using System.Collections.Generic;
using System.Text;

namespace StudentClassDemo
{
    class Student
    {
            private string major;

            public string GetMajor()
            {
                return major;
            }

            public void SetMajor(string major)
            {
                this.major = major;
            }

            private int score1;

            public int GetScore1()
            {
                return score1;
            }

            public void SetScore1(int score1)
            {
                this.score1 = score1;
                Calc();
            }

            private int score2;

            public int GetScore2()
            {
                return score2;
            }

            public void SetScore2(int score2)
            {
                this.score2 = score2;
                Calc();
            }

            private int score3;

            public int GetScore3()
            {
                return score3;
            }

            public void SetScore3(int score3)
            {
                this.score3 = score3;
                Calc();
            }

            private string firstName;

            public string GetFirstName()
            {
                return firstName;
            }

            public void SetFirstName(string firstName)
            {
                this.firstName = firstName;
            }

            private string lastName;

            public string GetLastName()
            {
                return lastName;
            }

            public void SetLastName(string lastName)
            {
                this.lastName = lastName;
            }

            private string studentNumber;

            public string GetStudentNum()
            {
                return studentNumber;
            }

            public void SetStudentNumber(string studentNumber)
            {
                this.studentNumber = studentNumber;
            }

            //Read only attributes
            private double average;

            public double GetAverage()
            {
                return average;
            }

            public string GetSummary()
            {
                return firstName + " " + lastName + " " + studentNumber
        + " Average: " + average;
            }

            //Private methods
            private void Calc()
            {
                average = (score1 + score2 + score3) / 3;
            }
        }
}
