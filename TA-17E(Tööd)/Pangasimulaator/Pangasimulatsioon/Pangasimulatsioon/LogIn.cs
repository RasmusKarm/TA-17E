using System;
using System.IO;

namespace Pangasimulatsioon
{
    public class SignIn
    {
        public bool IsSignedIn = false;

        public SignIn()
        {

        }

        public bool LogIn(string username, string path)
        {
            if (!IsSignedIn)
            {
                Console.WriteLine("");
                Console.WriteLine("Username: " + username);
                Console.WriteLine("");
                Console.Write("Pin: ");
                string pin = Console.ReadLine();

                if (File.Exists(path))
                {
                    StreamReader sr = new StreamReader(path);
                    string passWord = sr.ReadLine();
                    if (pin != passWord)
                    {
                        Console.WriteLine("Password is wrong");
                        return false;
                    }
                    else
                    {
                        IsSignedIn = true;
                        LoggedIn();
                        return true;
                    }
                }
                else
                {
                    Console.WriteLine("Username is wrong");
                    return false;
                }
            }
            else
            {
                return true;
            }
        }

        public bool LogIn2(string username, string path)
        {
            if (!IsSignedIn)
            {
                Console.WriteLine("");
                Console.WriteLine("Log In");
                Console.WriteLine("");
                Console.WriteLine($"UserName: {username}");
                Console.WriteLine("");
                Console.Write("Pin: ");
                string pin = Console.ReadLine();

                if (File.Exists(path))
                {
                    StreamReader sr = new StreamReader(path);
                    string passWord = sr.ReadLine();
                    if (pin != passWord)
                    {
                        Console.WriteLine("Password is wrong");
                        return false;
                    }
                    else
                    {
                        IsSignedIn = true;
                        LoggedIn();
                        return true;
                    }
                }
                else
                {
                    Console.WriteLine("Username is wrong");
                    return false;
                }
            }
            else
            {
                return true;
            }
        }

        public void LoggedIn()
        {
            Console.Clear();
            Console.WriteLine("You logged in!");
        }
    }
}