using ATMDataServices;
using ATMModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMBusinessServices
{
    public class MoneyService
    {
        public void WITH(int moneymoney)
        {
            Console.WriteLine("Money in bank: " + moneymoney);
            Console.WriteLine("Select amount to withdraw:");
            Console.WriteLine("1. 100");
            Console.WriteLine("2. 200");
            Console.WriteLine("3. 500");
            Console.WriteLine("4. 1,000");
            Console.WriteLine("5. 2,000");
            Console.WriteLine("6. 5,000");
            Console.WriteLine("7. 7,500");
            Console.WriteLine("8. 10,000");
            Console.WriteLine("9. Input");
            withdraw(moneymoney);
            static void withdraw(int moneymoney)
            {
                byte wd = Convert.ToByte(Console.ReadLine());
                switch (wd)
                {
                    case 1:
                        if (moneymoney >= 100) 
                        {
                            int one = moneymoney - 100;
                            Console.WriteLine("Sucessfully withdrawn 100 php");
                            Console.WriteLine($"Your account now contains: {one} php");
                            Console.WriteLine("Claim your money below");
                        }
                        else
                        {
                            Console.WriteLine("Haha walang pera");
                        }
                        break;
                    case 2:
                        if (moneymoney >= 200)
                        { 
                            int two = moneymoney - 200;
                            Console.WriteLine("Sucessfully withdrawn 200 php");
                            Console.WriteLine($"Your account now contains: {two} php");
                            Console.WriteLine("Claim your money below");
                        }
                        else
                        {
                            Console.WriteLine("Haha walang pera");
                        }
                        break;
                    case 3:
                        if (moneymoney >= 500)
                        {
                            int fiv = moneymoney - 500;
                            Console.WriteLine("Sucessfully withdrawn 500 php");
                            Console.WriteLine($"Your account now contains: {fiv} php");
                            Console.WriteLine("Claim your money below");
                        }
                        else
                        {
                            Console.WriteLine("Haha walang pera");
                        }
                        break;
                    case 4:
                        if (moneymoney >= 1000)
                        {
                            int k = moneymoney - 1000;
                            Console.WriteLine("Sucessfully withdrawn 1,000 php");
                            Console.WriteLine($"Your account now contains: {k} php");
                            Console.WriteLine("Claim your money below");
                        }
                        else
                        {
                            Console.WriteLine("Haha walang pera");
                        }
                        break;
                    case 5:
                        if (moneymoney >= 2000)
                        {
                            int twok = moneymoney - 2000;
                            Console.WriteLine("Sucessfully withdrawn 2,000 php");
                            Console.WriteLine($"Your account now contains: {twok} php");
                            Console.WriteLine("Claim your money below");
                        }
                        else
                        {
                            Console.WriteLine("Haha walang pera");
                        }
                        break;
                    case 6:
                        if (moneymoney >= 5000)
                        {
                            int fivek = moneymoney - 5000;
                            Console.WriteLine("Sucessfully withdrawn 5,000 php");
                            Console.WriteLine($"Your account now contains: {fivek} php");
                            Console.WriteLine("Claim your money below");
                        }
                        else
                        {
                            Console.WriteLine("Haha walang pera");
                        }
                        break;
                    case 7:
                        if (moneymoney >= 7500)
                        {
                            int sevfiv = moneymoney - 7500;
                            Console.WriteLine("Sucessfully withdrawn 7,500 php");
                            Console.WriteLine($"Your account now contains: {sevfiv} php");
                            Console.WriteLine("Claim your money below");
                        }
                        else
                        {
                            Console.WriteLine("Haha walang pera");
                        }
                        break;
                    case 8:
                        if (moneymoney >= 10000)
                        {
                            int tenk = moneymoney - 10000;
                            Console.WriteLine("Sucessfully withdrawn 10,000 php");
                            Console.WriteLine($"Your account now contains: {tenk} php");
                            Console.WriteLine("Claim your money below");
                        }
                        else
                        {
                            Console.WriteLine("Haha walang pera");
                        }
                        break;
                    case 9:
                        Console.Write("Input amount to withdraw: ");
                        int input = Convert.ToInt32(Console.ReadLine());
                        if (input <= moneymoney)
                        {
                            int inputted = moneymoney - input;
                            Console.WriteLine("Sucessfully withdrawn " + input + " php");
                            Console.WriteLine($"Your account now contains: {inputted} php");
                            Console.WriteLine("Claim your money below");
                        }
                        else
                        {
                            Console.WriteLine("Haha walang pera");
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid Input");
                        break;
                }
            }
        }
        public void DEPO(int dinero)
        {
            Console.WriteLine("Money in bank: " + dinero);
            Console.WriteLine("Select amount to withdraw:");
            Console.WriteLine("1. 100");
            Console.WriteLine("2. 200");
            Console.WriteLine("3. 500");
            Console.WriteLine("4. 1,000");
            Console.WriteLine("5. 2,000");
            Console.WriteLine("6. 5,000");
            Console.WriteLine("7. 7,500");
            Console.WriteLine("8. 10,000");
            Console.WriteLine("9. Input");
            deposit(dinero);
            static void deposit(int dinero)
            {
                byte dp = Convert.ToByte(Console.ReadLine());
                switch (dp)
                {
                    case 1:
                        int uno = dinero + 100;
                        Console.WriteLine("Sucessfully withdrawn 100 php");
                        Console.WriteLine($"Your account now contains: {uno} php");
                        Console.WriteLine("Claim your receipt below");
                        break;
                    case 2:
                        int dos = dinero + 200;
                        Console.WriteLine("Sucessfully withdrawn 200 php");
                        Console.WriteLine($"Your account now contains: {dos} php");
                        Console.WriteLine("Claim your receipt below");
                        break;
                    case 3:
                        int cinco = dinero + 500;
                        Console.WriteLine("Sucessfully withdrawn 500 php");
                        Console.WriteLine($"Your account now contains: {cinco} php");
                        Console.WriteLine("Claim your receipt below");
                        break;
                    case 4:
                        int libo = dinero + 1000;
                        Console.WriteLine("Sucessfully withdrawn 1,000 php");
                        Console.WriteLine($"Your account now contains: {libo} php");
                        Console.WriteLine("Claim your receipt below");
                        break;
                    case 5:
                        int dosk = dinero + 2000;
                        Console.WriteLine("Sucessfully withdrawn 2,000 php");
                        Console.WriteLine($"Your account now contains: {dosk} php");
                        Console.WriteLine("Claim your receipt below");
                        break;
                    case 6:
                        int cinck = dinero + 5000;
                        Console.WriteLine("Sucessfully withdrawn 5,000 php");
                        Console.WriteLine($"Your account now contains: {cinck} php");
                        Console.WriteLine("Claim your receipt below");
                        break;
                    case 7:
                        int sietcinc = dinero + 7500;
                        Console.WriteLine("Sucessfully withdrawn 7,500 php");
                        Console.WriteLine($"Your account now contains: {sietcinc} php");
                        Console.WriteLine("Claim your receipt below");
                        break;
                    case 8:
                        int diesk = dinero + 10000;
                        Console.WriteLine("Sucessfully withdrawn 10,000 php");
                        Console.WriteLine($"Your account now contains: {diesk} php");
                        Console.WriteLine("Claim your receipt below");
                        break;
                    case 9:
                        Console.Write("Input amount to deposit: ");
                        int input = Convert.ToInt32(Console.ReadLine());
                        int inputted = dinero + input;
                        Console.WriteLine("Sucessfully deposited " + input + " php");
                        Console.WriteLine($"Your account now contains: {inputted} php");
                        Console.WriteLine("Claim your receipt below");
                        break;
                    default:
                        Console.WriteLine("Invalid Input");
                        break;
                }
            }
        }
    }
}
