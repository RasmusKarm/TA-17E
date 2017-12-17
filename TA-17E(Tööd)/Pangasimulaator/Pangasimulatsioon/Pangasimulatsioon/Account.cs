using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Pangasimulatsioon
{
    public class Account
    {
        string UserName;
        SignIn signIn = new SignIn();
        Register register = new Register();

        public bool AccountCreation(string userName, string pin, string path)
        {
            if (!File.Exists(path))
            {
                string[] lines = new string[2] { pin, "0" };
                File.WriteAllLines(path, lines);
                Console.Clear();
                Console.WriteLine("You signed up!");
                UserName = userName;
                return true;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("That username is taken.");
                return false;
            }
        }

        public void Deposit(string path)
        {
            List<string> lines = new List<string>();
            lines = File.ReadLines(path).ToList();
            string currentBalance = lines[1];
            int currentBalanceint = int.Parse(lines[1]);

            Console.Write("What is the amount you want to deposit?: ");
            int amount = int.Parse(Console.ReadLine());
            int newBalance = currentBalanceint + amount;

            string text = File.ReadAllText(path);
            string newText = text.Replace(currentBalance, newBalance.ToString());
            File.WriteAllText(path, newText);
            Console.WriteLine("\n" + "Successful Deposit.");
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }

        public void withdrawl(string path)
        {
            List<string> lines = new List<string>();
            lines = File.ReadLines(path).ToList();
            string currentBalance = lines[1];
            int currentBalanceint = int.Parse(lines[1]);

            Console.Write("What is the amount you want to withdrawl?: ");
            int amount = int.Parse(Console.ReadLine());
            int newBalance = currentBalanceint - amount;

            string text = File.ReadAllText(path);
            string newText = text.Replace(currentBalance, newBalance.ToString());
            File.WriteAllText(path, newText);
            Console.WriteLine("\n" + "Successful Withdrawl.");
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }

        public void checkBalance(string path)
        {
            List<string> lines = new List<string>();
            lines = File.ReadLines(path).ToList();
            Console.WriteLine($"Your current balance is: {lines[1]}.00$");
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }
    }
}