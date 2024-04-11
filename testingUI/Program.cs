using ATMDataServices;
using ATMBusinessServices;
using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.X86;
using ATMModel;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;

namespace testingUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, welcome to Aguas E-wallet ATM");
            Console.WriteLine("Please insert your E-wallet card pin");
            string Pin = Console.ReadLine();
            EWDataService data = new EWDataService();
            EWService service = new EWService();
            MoneyService monkey = new MoneyService();
            bool result = service.VerifyPin(Pin);
            if (result)
            {
                if (Pin == "12")
                {
                    EWallet show = data.GetUser1();
                    int bank = show.money.amount;
                    Console.WriteLine($"Hello, {show.name}!");
                    Console.WriteLine($"EWallet Money: {show.money.amount}php");
                    Proceed(bank);

                }
                else if (Pin == "123")
                {
                    EWallet show = data.GetUser2();
                    int bank = show.money.amount;
                    Console.WriteLine($"Hello, {show.name}!");
                    Console.WriteLine($"EWallet Money: {show.money.amount}php");
                    Proceed(bank);
                }
                else if (Pin == "1234")
                {
                    EWallet show = data.GetUser3();
                    int bank = show.money.amount;
                    Console.WriteLine($"Hello, {show.name}!");
                    Console.WriteLine($"EWallet Money: {show.money.amount}php");
                    Proceed(bank);
                }

                void Proceed(int bank)
                {
                    Console.WriteLine($"Amount: {bank}");
                    Console.WriteLine("Please select a transaction to be done:");
                    Console.WriteLine("1. Withdraw");
                    Console.WriteLine("2. Deposit");
                    byte choice = Convert.ToByte(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            monkey.WITH(bank);
                            break;
                        case 2:
                            monkey.DEPO(bank);
                            break;
                        default:
                            Console.WriteLine("Invalid Input");
                            break;
                    }
                }
                
            }
            else
            {
                Console.WriteLine("Not registered bro");
            }
        }
    }
}
