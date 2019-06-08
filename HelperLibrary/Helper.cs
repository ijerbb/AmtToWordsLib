using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelperLibrary
{
    public static class Helper
    {
        public static string ConvertAmountToWords(int value)
        {
            string amountInWords = "";

            try
            {
                if (value == 10
                    || value == 20
                    || value == 30
                    || value == 40
                    || value == 50
                    || value == 60
                    || value == 70
                    || value == 80
                    || value == 90)
                {
                    switch (value)
                    {
                        case 10: amountInWords = "ten"; break;
                        case 20: amountInWords = "twenty"; break;
                        case 30: amountInWords = "thirty"; break;
                        case 40: amountInWords = "forty"; break;
                        case 50: amountInWords = "fifty"; break;
                        case 60: amountInWords = "sixty"; break;
                        case 70: amountInWords = "seventy"; break;
                        case 80: amountInWords = "eighty"; break;
                        case 90: amountInWords = "ninety"; break;
                    }
                }
                else if (value < 10)
                {
                    switch (value)
                    {
                        case 1: amountInWords = "one"; break;
                        case 2: amountInWords = "two"; break;
                        case 3: amountInWords = "three"; break;
                        case 4: amountInWords = "four"; break;
                        case 5: amountInWords = "five"; break;
                        case 6: amountInWords = "six"; break;
                        case 7: amountInWords = "seven"; break;
                        case 8: amountInWords = "eight"; break;
                        case 9: amountInWords = "nine"; break;
                    }
                }
                else if (value < 20)
                {
                    switch (value)
                    {
                        case 11: amountInWords = "eleven"; break;
                        case 12: amountInWords = "twelve"; break;
                        case 13: amountInWords = "thirteen"; break;
                        case 14: amountInWords = "fourteen"; break;
                        case 15: amountInWords = "fifteen"; break;
                        case 16: amountInWords = "sixteen"; break;
                        case 17: amountInWords = "seventeen"; break;
                        case 18: amountInWords = "eighteen"; break;
                        case 19: amountInWords = "nineteen"; break;
                    }
                }
                else
                {
                    int quotient = 0;
                    if ((value / 1000000) >= 1)
                    {
                        quotient = (int)(value / 1000000);
                        amountInWords = Helper.ConvertAmountToWords(quotient) + " million"
                            + (value - (quotient * 1000000) == 0 ? "" : " ") + Helper.ConvertAmountToWords(value - (quotient * 1000000));
                    }
                    else if ((value / 1000) >= 1)
                    {
                        quotient = (int)(value / 1000);
                        amountInWords = Helper.ConvertAmountToWords(quotient) + " thousand"
                            + (value - (quotient * 1000) == 0 ? "" : " ") + Helper.ConvertAmountToWords(value - (quotient * 1000));
                    }
                    else if ((value / 100) >= 1)
                    {
                        quotient = (int)(value / 100);
                        amountInWords = Helper.ConvertAmountToWords(quotient) + " hundred"
                            + (value - (quotient * 100) == 0 ? "" : " ") + Helper.ConvertAmountToWords(value - (quotient * 100));
                    }
                    else if ((value / 10) >= 1)
                    {
                        quotient = (int)(value / 10);
                        amountInWords = Helper.ConvertAmountToWords(quotient * 10)
                            + ((value - (quotient * 10)) == 0 ? "" : "-") + Helper.ConvertAmountToWords(value - (quotient * 10));
                    }
                }
            }
            catch (Exception e) {
                Console.WriteLine(e.Message);
                //Incomplete -- there should be a logger class
            }

            return amountInWords;
        }
    }
}
