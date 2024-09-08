using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_1
{
    internal class Program
    {
        //Function converting INTO USD

        //EDIT: Changed the static void to public static double because that's right, I think. Not sure what it does outside of being correct syntax-wise.
        public static double ConvertToUSD(double amount, string fromCurrency)
        {
            //Checks if from EUR or JPY
            //I used Google's stock result for exchange rates, and tried to adhere well. It is, admittedly, not perfect to the decimal.
            if (fromCurrency == "EUR")
            {
                amount = (amount / 9) * 10;
            }
            if (fromCurrency == "JPY")
            {
                amount = (amount / 1000) * 7.03;
            }
            Console.WriteLine("Your amount in USD is: " + amount);
            return amount;
        }
        public static double ConvertToEUR(double amount, string fromCurrency)
        {
            //Same as the others. Learned that the conversion is reversed when going the other way, which makes a lot of sense in hindsight!
            if (fromCurrency == "USD")
            {
                amount = (amount / 10) * 9;
            }
            if (fromCurrency == "JPY")
            {
                amount = (amount / 1000) * 6.33;
            }
            Console.WriteLine("Your amount in EUR is: " + amount);
            return amount;
        }
        public static double ConvertToJPY(double amount, string fromCurrency)
        {
            if (fromCurrency == "USD")
            {
                amount = (amount / 7.03) * 1000;
            }
            if (fromCurrency == "EUR")
            {
                amount = (amount / 6.33) * 1000;
            }
            Console.WriteLine("Your amount in JPY is: " + amount);
            return amount;
        }

        static void Main(string[] args)
        {
            //User inputs the pure amount
            Console.WriteLine("CURRENCY CONVERTER");
            Console.WriteLine("Enter the amount of currency: ");
            double amount = Convert.ToDouble(Console.ReadLine());
            //User enters fromCurrency
            Console.WriteLine("Enter the currency that you converting from (USD, EUR, JPY): ");
            string fromCurrency = Console.ReadLine();
            //User inputs the currency they are converting to, which the code checks for and sends to each function
            Console.WriteLine("Enter the currency you are converting to (USD, EUR, JPY): ");
            string toCurrency = Console.ReadLine();

            //I didn't include a failsafe for not inputting USD, EUR, or JPY, but I can if that is wanted
            //checks for each currency, gets sent out, then is read out and user gets their amount
            if (toCurrency == "USD")
                ConvertToUSD(amount, fromCurrency);
            if (toCurrency == "EUR")
                ConvertToEUR(amount, fromCurrency);
            if (toCurrency == "JPY")
                ConvertToJPY(amount, fromCurrency);

            Console.ReadLine();
        }
    }
}
