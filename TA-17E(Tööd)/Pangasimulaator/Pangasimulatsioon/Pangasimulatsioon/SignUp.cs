using System;
using System.IO;

namespace Pangasimulatsioon
{
    public class Register
    {
        public bool IsSignedUp = false;
        public string RightPath;

        public bool SignUp(string userName, Account account, string path)
        {
            RightPath = path;
            bool isCreated = false;
            bool dejavu = false;
            while (!isCreated)
            {
                if (dejavu)
                {
                    Console.WriteLine("Sign Up");
                    Console.WriteLine("");
                    Console.Write("Create username: ");
                    userName = Console.ReadLine();
                    path = userName + ".txt";
                    RightPath = path;
                }
                Console.WriteLine("");
                Console.Write("Create Pin: ");
                string pin = Console.ReadLine();

                if (!account.AccountCreation(userName, pin, path))
                {
                    isCreated = false;
                }
                else
                {
                    SignIn signIn = new SignIn();
                    signIn.LogIn2(userName, path);
                    IsSignedUp = true;
                    isCreated = true;
                }
                dejavu = true;
            }
            return true;
        }
    }
}