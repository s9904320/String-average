using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xunit;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace homework1
{
    class Program
    {

        /*
        You are given a string of numbers between 0-9.
        Find the average of these numbers and return it as a floored whole number(ie: no decimal places) written out as a string. Eg:
        "zero nine five two" -> "four"
        If the string is empty or includes a number greater than 9, return "n/a"
        */

        static void Main(string[] args)
        {
            SampleTests();
        }
        public static string AverageString(string str)
        {
            // Code away
            string[] Num = str.Split(' ');
            int allNumTotal = 0;
            int numCount;
            int avgNum;

            for (numCount = 0; numCount < Num.Length; numCount++)
            {
                switch (Num[numCount])
                {
                    case "zero":
                        allNumTotal += 0;
                        break;
                    case "one":
                        allNumTotal += 1;
                        break;
                    case "two":
                        allNumTotal += 2;
                        break;
                    case "three":
                        allNumTotal += 3;
                        break;
                    case "four":
                        allNumTotal += 4;
                        break;
                    case "five":
                        allNumTotal += 5;
                        break;
                    case "six":
                        allNumTotal += 6;
                        break;
                    case "seven":
                        allNumTotal += 7;
                        break;
                    case "eight":
                        allNumTotal += 8;
                        break; 
                    case "nine":
                        allNumTotal += 9;
                        break;
                    default:
                        allNumTotal = -1;
                        numCount = Num.Length;
                        break;
                }
            }

            if (allNumTotal >= 0)
            {
                avgNum = allNumTotal / numCount;
                switch (avgNum)
                {
                    case 0:
                        str = "zero";
                        break;
                    case 1:
                        str = "one";
                        break;
                    case 2:
                        str = "two";
                        break;
                    case 3:
                        str = "three";
                        break;
                    case 4:
                        str = "four";
                        break;
                    case 5:
                        str = "five";
                        break;
                    case 6:
                        str = "six";
                        break;
                    case 7:
                        str = "seven";
                        break;
                    case 8:
                        str = "eight";
                        break;
                    case 9:
                        str = "nine";
                        break;
                    default:
                        str = "n/a";
                        break;
                }
            }
            else
            {
                str = "n/a";
            }

            return str;
        }

        [TestMethod()]
        public static void SampleTests()
        {
            Assert.AreEqual("four", AverageString("zero nine five two"));
            Assert.AreEqual("three", AverageString("four six two three"));
            Assert.AreEqual("three", AverageString("one two three four five"));
            Assert.AreEqual("four", AverageString("five four"));
            Assert.AreEqual("zero", AverageString("zero zero zero zero zero"));
            Assert.AreEqual("two", AverageString("one one eight one"));
            Assert.AreEqual("n/a", AverageString(""));
        }
    }
}
