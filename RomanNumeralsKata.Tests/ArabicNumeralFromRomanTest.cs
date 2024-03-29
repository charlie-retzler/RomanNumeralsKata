﻿using System;
using Xunit;

namespace RomanNumeralsKata.Tests
{
    public class ArabicNumeralFromRomanTest
    {
        ArabicNumerals arabicNumerals = new ArabicNumerals();

        [Fact]
        public void When_I_Is_Input_Should_Result_In_1()
        {
            var result = arabicNumerals.FromRoman("I");
            Assert.Equal(1, result);
        }

        [Fact]
        public void When_II_Is_Input_Should_Result_In_2()
        {
            var result = arabicNumerals.FromRoman("II");
            Assert.Equal(2, result);
        }

        [Fact]
        public void When_III_Is_Input_Should_Result_In_3()
        {
            var result = arabicNumerals.FromRoman("III");
            Assert.Equal(3, result);
        }

        [Fact]
        public void When_IV_Is_Input_Should_Result_In_4()
        {
            var result = arabicNumerals.FromRoman("IV");
            Assert.Equal(4, result);
        }

        [Fact]
        public void When_V_Is_Input_Should_Result_In_5()
        {
            var result = arabicNumerals.FromRoman("V");
            Assert.Equal(5, result);
        }

        [Fact]
        public void When_VI_Is_Input_Should_Result_In_6()
        {
            var result = arabicNumerals.FromRoman("VI");
            Assert.Equal(6, result);
        }

        [Fact]
        public void When_VII_Is_Input_Should_Result_In_7()
        {
            var result = arabicNumerals.FromRoman("VII");
            Assert.Equal(7, result);
        }

        [Fact]
        public void When_VIII_Is_Input_Should_Result_In_8()
        {
            var result = arabicNumerals.FromRoman("VIII");
            Assert.Equal(8, result);
        }

        [Fact]
        public void When_IX_Is_Input_Should_Result_In_9()
        {
            var result = arabicNumerals.FromRoman("IX");
            Assert.Equal(9, result);
        }

        [Fact]
        public void When_X_Is_Input_Should_Result_In_10()
        {
            var result = arabicNumerals.FromRoman("X");
            Assert.Equal(10, result);
        }

        
        [Fact]
        public void When_XI_Is_Input_Should_Result_In_11()
        {
            var result = arabicNumerals.FromRoman("XI");
            Assert.Equal(11, result);
        }
        
        [Fact]
        public void When_XII_Is_Input_Should_Result_In_12()
        {
            var result = arabicNumerals.FromRoman("XII");
            Assert.Equal(12, result);
        }
        
        [Fact]
        public void When_XIII_Is_Input_Should_Result_In_13()
        {
            var result = arabicNumerals.FromRoman("XIII");
            Assert.Equal(13, result);
        }

        [Fact]
        public void When_XIV_Is_Input_Should_Result_In_14()
        {
            var result = arabicNumerals.FromRoman("XIV");
            Assert.Equal(14, result);
        }
        
        [Fact]
        public void When_XIX_Is_Input_Should_Result_In_19()
        {
            var result = arabicNumerals.FromRoman("XIX");
            Assert.Equal(19, result);
        }

        [Fact]
        public void When_XX_Is_Input_Should_Result_In_20()
        {
            var result = arabicNumerals.FromRoman("XX");
            Assert.Equal(20, result);
        }

        [Fact]
        public void When_XL_Is_Input_Should_Result_In_40()
        {
            var result = arabicNumerals.FromRoman("XL");
            Assert.Equal(40, result);
        }

        [Fact]
        public void When_XL_Is_Input_Should_Result_In_50()
        {
            var result = arabicNumerals.FromRoman("L");
            Assert.Equal(50, result);
        }

        
        [Fact]
        public void When_XCIX_Is_Input_Should_Result_In_99()
        {
            var result = arabicNumerals.FromRoman("XCIX");
            Assert.Equal(99, result);
        }

        [Fact]
        public void When_C_Is_Input_Should_Result_In_100()
        {
            var result = arabicNumerals.FromRoman("C");
            Assert.Equal(100, result);
        }

        [Fact]
        public void When_CCC_Is_Input_Should_Result_In_300()
        {
            var result = arabicNumerals.FromRoman("CCC");
            Assert.Equal(300, result);
        }

        [Fact]
        public void When_CD_Is_Input_Should_Result_In_400()
        {
            var result = arabicNumerals.FromRoman("CD");
            Assert.Equal(400, result);
        }

        [Fact]
        public void When_D_Is_Input_Should_Result_In_500()
        {
            var result = arabicNumerals.FromRoman("D");
            Assert.Equal(500, result);
        }

        [Fact]
        public void When_CM_Is_Input_Should_Result_In_900()
        {
            var result = arabicNumerals.FromRoman("CM");
            Assert.Equal(900, result);
        }

        [Fact]
        public void When_M_Is_Input_Should_Result_In_1000()
        {
            var result = arabicNumerals.FromRoman("M");
            Assert.Equal(1000, result);
        }

        [Fact]
        public void When_AAA_Is_Input_Should_Result_In_Exception()
        {
            Assert.Throws<ArgumentException>(() => arabicNumerals.FromRoman("AAA"));
        }

        [Fact]
        public void When_IIII_Is_Input_Should_Result_In_Exception()
        {
            Assert.Throws<ArgumentException>(() => arabicNumerals.FromRoman("IIII"));
        }

    }
}
