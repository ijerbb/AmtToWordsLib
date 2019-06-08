using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelperLibrary;

namespace AmountToWordsConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isEndLoop = false;
            do
            {
                Console.WriteLine("Please any number(integer) to be converted to words (Press Q to exit): ");
                string inputValue = Console.ReadLine();
                isEndLoop = int.TryParse(inputValue, out int value);
                if (isEndLoop)
                {
                    Console.WriteLine(Helper.ConvertAmountToWords(Convert.ToInt32(inputValue)));
                    Console.WriteLine(""); // Space
                }
                else if (!inputValue.ToUpper().Equals("Q"))
                {
                    Console.WriteLine("Invalid input value. Please enter a number");
                    isEndLoop = true; // reset until user enters Q 
                }
            } while (isEndLoop);
        }
    }
}
