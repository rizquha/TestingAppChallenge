using System;
using Xunit;
using System.Collections.Generic;
using ChallengeApp;


namespace UnitTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test_BasicStatistic()
        {
            int[] numbers = {5, 2, 5, 77, 100, 31, 3, -13, 4, 0, -19};
            Assert.Equal(100,BasicStatistic.FindMax(numbers));
            Assert.Equal(-19,BasicStatistic.FindMin(numbers));
            Assert.Equal(17.727272727272727,BasicStatistic.CalculateAverage(numbers));
            Assert.Equal(195,BasicStatistic.CalculateTotal(numbers));
        }

        [Fact]
        public void Test_FlatArray()
        {
            int[] theFirstArray = {2, 52, 56, 12, 3};
            int[] theSecondArray = {1, 0, 65, 42};
            int[] theThirdArray = {3, 4, 6};
            int[] ExpectedResult = {0, 1, 2, 3, 3, 4, 6, 12, 42, 52, 56, 65};
            Assert.Equal(ExpectedResult,FlatArray.Combine(theFirstArray,theSecondArray,theThirdArray));
        }

        [Fact]
        public void Test_GenerateCalendar()
        {
            string expected =  "January 2020"
                              +"--------------------"
                              +"Su Mo Tu We Th Fr Sa"
                              +"          1  2  3  4 \n"
                              +" 5  6  7  8  9 10 11 \n"
                              +"12 13 14 15 16 17 18 \n"
                              +"19 20 21 22 23 24 25 \n"
                              +"26 27 28 29 30 31 \n";

            Assert.Equal(expected,GenerateCalendar.Run(2020,1));
        }

        [Fact]
        public void Test_HowManyDuplicates()
        {
            int[] dups = {1, 3, 5, 1, 4, 5, 2, 4, 3, 5, 3, 1};
            string expected= "1 -> 3x \n"
                      +"2 -> 1x \n"
                      +"3 -> 3x \n"
                      +"4 -> 2x \n"
                      +"5 -> 3x \n";
            
            Assert.Equal(expected,HowManyDuplicates.duplicate(dups));
        }

        [Fact]
        public void Test_MultiplicationOfTwoArray()
        {
            int[] firstArray = {1, 3, -5, 4};
            int[] secondArray = {1, 4, -5, -2};
            int[] expected = {1, 12, 25, -8};

            Assert.Equal(expected,MultiplicationOfTwoArray.Run(firstArray,secondArray));
        }

        [Fact]
        public void Test_Separator()
        {
            string str = "minum susu sapi";
            string expected1 = "m-i-n-u-m-s-u-s-u-s-a-p-i";
            string expected2 = "m*i*n*u*m*s*u*s*u*s*a*p*i";

            Assert.Equal(expected1,Separator.Run(str,"-"));
            Assert.Equal(expected2,Separator.Run(str,"*"));

        }

        
        [Fact]
        public void Test_TriangleOfNumbers()
        {
            var expected = "1\n"
                          +"12\n"
                          +"123\n";
            Assert.Equal(expected,TriangleOfNumbers.Run(3));
        }

        [Fact]
        public void Test_TriangleStars()
        {
            var expected = "*\n"
                          +"**\n"
                          +"***\n";
            Assert.Equal(expected,TriangleStars.Run(3));
        }

        [Fact]
        public void Test_VowelToUppercase()
        {
            string str ="rasanya otakku semakin keram";
            string expected ="rAsAnyA OtAkkU sEmAkIn kErAm";
            Assert.Equal(expected,VowelToUppercase.Run(str));
        }

    }
}
