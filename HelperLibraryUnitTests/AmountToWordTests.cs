using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelperLibrary;

namespace HelperLibraryUnitTests
{
    [TestClass]
    public class AmountToWordTests
    {
        int value = 0;
        string expected = "", result = "";

        [TestMethod]
        public void SingleDigit_FixedValue()
        {
            //Arrange
            value = 1;
            expected = "one";
            //Act
            result = Helper.ConvertAmountToWords(value);
            //Assert
            Assert.AreEqual(expected, result);

            //Arrange
            value = 2;
            expected = "two";
            //Act
            result = Helper.ConvertAmountToWords(value);
            //Assert
            Assert.AreEqual(expected, result);

            //Arrange
            value = 3;
            expected = "three";
            //Act
            result = Helper.ConvertAmountToWords(value);
            //Assert
            Assert.AreEqual(expected, result);

            //Arrange
            value = 4;
            expected = "four";
            //Act
            result = Helper.ConvertAmountToWords(value);
            //Assert
            Assert.AreEqual(expected, result);

            //Arrange
            value = 5;
            expected = "five";
            //Act
            result = Helper.ConvertAmountToWords(value);
            //Assert
            Assert.AreEqual(expected, result);

            //Arrange
            value = 6;
            expected = "six";
            //Act
            result = Helper.ConvertAmountToWords(value);
            //Assert
            Assert.AreEqual(expected, result);

            //Arrange
            value = 7;
            expected = "seven";
            //Act
            result = Helper.ConvertAmountToWords(value);
            //Assert
            Assert.AreEqual(expected, result);

            //Arrange
            value = 8;
            expected = "eight";
            //Act
            result = Helper.ConvertAmountToWords(value);
            //Assert
            Assert.AreEqual(expected, result);

            //Arrange
            value = 9;
            expected = "nine";
            //Act
            result = Helper.ConvertAmountToWords(value);
            //Assert
            Assert.AreEqual(expected, result);
        }


        [TestMethod]
        public void DoubleDigit_FixedValue()
        {
            //Arrange
            value = 11;
            expected = "eleven";
            //Act
            result = Helper.ConvertAmountToWords(value);
            //Assert
            Assert.AreEqual(expected, result);

            //Arrange
            value = 12;
            expected = "twelve";
            //Act
            result = Helper.ConvertAmountToWords(value);
            //Assert
            Assert.AreEqual(expected, result);

            //Arrange
            value = 13;
            expected = "thirteen";
            //Act
            result = Helper.ConvertAmountToWords(value);
            //Assert
            Assert.AreEqual(expected, result);

            //Arrange
            value = 14;
            expected = "fourteen";
            //Act
            result = Helper.ConvertAmountToWords(value);
            //Assert
            Assert.AreEqual(expected, result);

            //Arrange
            value = 15;
            expected = "fifteen";
            //Act
            result = Helper.ConvertAmountToWords(value);
            //Assert
            Assert.AreEqual(expected, result);

            //Arrange
            value = 16;
            expected = "sixteen";
            //Act
            result = Helper.ConvertAmountToWords(value);
            //Assert
            Assert.AreEqual(expected, result);

            //Arrange
            value = 17;
            expected = "seventeen";
            //Act
            result = Helper.ConvertAmountToWords(value);
            //Assert
            Assert.AreEqual(expected, result);

            //Arrange
            value = 18;
            expected = "eighteen";
            //Act
            result = Helper.ConvertAmountToWords(value);
            //Assert
            Assert.AreEqual(expected, result);

            //Arrange
            value = 19;
            expected = "nineteen";
            //Act
            result = Helper.ConvertAmountToWords(value);
            //Assert
            Assert.AreEqual(expected, result);


            //Arrange
            value = 10;
            expected = "ten";
            //Act
            result = Helper.ConvertAmountToWords(value);
            //Assert
            Assert.AreEqual(expected, result);

            //Arrange
            value = 20;
            expected = "twenty";
            //Act
            result = Helper.ConvertAmountToWords(value);
            //Assert
            Assert.AreEqual(expected, result);

            //Arrange
            value = 30;
            expected = "thirty";
            //Act
            result = Helper.ConvertAmountToWords(value);
            //Assert
            Assert.AreEqual(expected, result);

            //Arrange
            value = 40;
            expected = "forty";
            //Act
            result = Helper.ConvertAmountToWords(value);
            //Assert
            Assert.AreEqual(expected, result);

            //Arrange
            value = 50;
            expected = "fifty";
            //Act
            result = Helper.ConvertAmountToWords(value);
            //Assert
            Assert.AreEqual(expected, result);

            //Arrange
            value = 60;
            expected = "sixty";
            //Act
            result = Helper.ConvertAmountToWords(value);
            //Assert
            Assert.AreEqual(expected, result);

            //Arrange
            value = 70;
            expected = "seventy";
            //Act
            result = Helper.ConvertAmountToWords(value);
            //Assert
            Assert.AreEqual(expected, result);

            //Arrange
            value = 80;
            expected = "eighty";
            //Act
            result = Helper.ConvertAmountToWords(value);
            //Assert
            Assert.AreEqual(expected, result);

            //Arrange
            value = 90;
            expected = "ninety";
            //Act
            result = Helper.ConvertAmountToWords(value);
            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void AmountInHundreds()
        {
            //Arrange
            value = 100;
            expected = "one hundred";
            //Act
            result = Helper.ConvertAmountToWords(value);
            //Assert
            Assert.AreEqual(expected, result);

            //Arrange
            value = 101;
            expected = "one hundred one";
            //Act
            result = Helper.ConvertAmountToWords(value);
            //Assert
            Assert.AreEqual(expected, result);

            //Arrange
            value = 210;
            expected = "two hundred ten";
            //Act
            result = Helper.ConvertAmountToWords(value);
            //Assert
            Assert.AreEqual(expected, result);

            //Arrange
            value = 311;
            expected = "three hundred eleven";
            //Act
            result = Helper.ConvertAmountToWords(value);
            //Assert
            Assert.AreEqual(expected, result);

            //Arrange
            value = 422;
            expected = "four hundred twenty-two";
            //Act
            result = Helper.ConvertAmountToWords(value);
            //Assert
            Assert.AreEqual(expected, result);

            //Arrange
            value = 987;
            expected = "nine hundred eighty-seven";
            //Act
            result = Helper.ConvertAmountToWords(value);
            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void AmountInThousands()
        {
            //Arrange
            value = 1000;
            expected = "one thousand";
            //Act
            result = Helper.ConvertAmountToWords(value);
            //Assert
            Assert.AreEqual(expected, result);

            //Arrange
            value = 2003;
            expected = "two thousand three";
            //Act
            result = Helper.ConvertAmountToWords(value);
            //Assert
            Assert.AreEqual(expected, result);

            //Arrange
            value = 10014;
            expected = "ten thousand fourteen";
            //Act
            result = Helper.ConvertAmountToWords(value);
            //Assert
            Assert.AreEqual(expected, result);

            //Arrange
            value = 14526;
            expected = "fourteen thousand five hundred twenty-six";
            //Act
            result = Helper.ConvertAmountToWords(value);
            //Assert
            Assert.AreEqual(expected, result);

            //Arrange
            value = 256128;
            expected = "two hundred fifty-six thousand one hundred twenty-eight";
            //Act
            result = Helper.ConvertAmountToWords(value);
            //Assert
            Assert.AreEqual(expected, result);

            //Arrange
            value = 999888;
            expected = "nine hundred ninety-nine thousand eight hundred eighty-eight";
            //Act
            result = Helper.ConvertAmountToWords(value);
            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void AmountInMillions()
        {
            //Arrange
            value = 1000000;
            expected = "one million";
            //Act
            result = Helper.ConvertAmountToWords(value);
            //Assert
            Assert.AreEqual(expected, result);

            //Arrange
            value = 1000001;
            expected = "one million one";
            //Act
            result = Helper.ConvertAmountToWords(value);
            //Assert
            Assert.AreEqual(expected, result);

            //Arrange
            value = 1000012;
            expected = "one million twelve";
            //Act
            result = Helper.ConvertAmountToWords(value);
            //Assert
            Assert.AreEqual(expected, result);

            //Arrange
            value = 1000240;
            expected = "one million two hundred forty";
            //Act
            result = Helper.ConvertAmountToWords(value);
            //Assert
            Assert.AreEqual(expected, result);

            //Arrange
            value = 1789453;
            expected = "one million seven hundred eighty-nine thousand four hundred fifty-three";
            //Act
            result = Helper.ConvertAmountToWords(value);
            //Assert
            Assert.AreEqual(expected, result);

            //Arrange
            value = 16745086;
            expected = "sixteen million seven hundred forty-five thousand eighty-six";
            //Act
            result = Helper.ConvertAmountToWords(value);
            //Assert
            Assert.AreEqual(expected, result);

            //Arrange
            value = 987654321;
            expected = "nine hundred eighty-seven million six hundred fifty-four thousand three hundred twenty-one";
            //Act
            result = Helper.ConvertAmountToWords(value);
            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}
