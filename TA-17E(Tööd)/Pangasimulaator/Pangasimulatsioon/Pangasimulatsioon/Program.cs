using System;
using System.IO;

namespace Pangasimulatsioon
{
    class Program
    {
        static void Main(string[] args)
        {
            Register register = new Register();
            SignIn signIn = new SignIn();
            Account account = new Account();
            bool loggedIn = false;
            string userName = "";
            string Path = userName + ".txt";

            while (!loggedIn)
            {
                Console.Clear();
                Console.WriteLine("1.)SIGN UP");
                Console.WriteLine("2.)LOG IN");
                Console.Write("Insert nr: ");
                string input = Console.ReadLine();
                Console.Clear();

                if (input == "1")
                {
                    Console.WriteLine("Sign Up");
                    Console.WriteLine("");
                    Console.Write("Create username: ");
                }
                if (input == "2")
                {
                    Console.WriteLine("Log In");
                    Console.WriteLine("");
                    Console.Write("Username: ");
                }

                userName = Console.ReadLine();
                Path = userName + ".txt";

                if (input == "1")
                {
                    Console.Clear();
                    Console.WriteLine("Sign Up");
                    if (register.SignUp(userName, account, Path))
                    {
                        loggedIn = true;
                        Path = register.RightPath;
                    }
                }
                if (input == "2")
                {
                    Console.Clear();
                    Console.WriteLine("Log In");
                    if (signIn.LogIn(userName, Path))
                    {
                        loggedIn = true;
                    }
                }

                while (loggedIn)
                {
                    Console.Clear();
                    Console.WriteLine("1.Deposit)");
                    Console.WriteLine("2.Withdrawl)");
                    Console.WriteLine("3.Check Balance)");
                    Console.WriteLine("4.Log out)");
                    Console.Write("Insert nr: ");
                    string input2 = Console.ReadLine();

                    switch (input2)
                    {
                        case "1":
                            account.Deposit(Path);
                            break;
                        case "2":
                            account.withdrawl(Path);
                            break;
                        case "3":
                            account.checkBalance(Path);
                            break;
                        case "4":
                            loggedIn = false;
                            userName = null;
                            signIn.IsSignedIn = false;
                            break;
                    }
                }
            }

        }
    }
}