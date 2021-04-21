using System;

namespace QAAutomationFirstProg
{
    class Program
    {
        class Credentials
        {
            private string loginName;
            private string password;
            private string secretAnswer;
            public Credentials(string loginName, string password, string secretAnswer)
            {
                this.loginName = loginName;
                this.password = password;
                this.secretAnswer = secretAnswer;
            }
            public bool IsEquals(Credentials creds)
            {
                return (loginName == creds.loginName && password == creds.password && secretAnswer == creds.secretAnswer);
            }
        }
        // Entry point
        static void Main(string[] args)
        {
            Credentials cred = new Credentials("name2", "password2", "secretAnswer2");
            if (CheckAuthentification(cred) == true)
            {
                Login();
                Console.WriteLine("Successful!");
            }
            else
            {
                throw new Exception("Can't authentificate!");
            }
        }
        static bool CheckAuthentification(Credentials creds)
        {
            Credentials[] dbCredentials = GetCredentialsFromDB();
            foreach (Credentials credData in dbCredentials)
            {
                if (credData.IsEquals(creds))
                {
                    return true;
                }
            }
            return false;
        }
        static void Login()
        {
            /// Login
        }
        static Credentials[] GetCredentialsFromDB()
        {
            // Data base
            Credentials[] dataBaseCreds = new Credentials[3];
            dataBaseCreds[0] = new Credentials("name1", "password1", "secretAnswer1");
            dataBaseCreds[1] = new Credentials("name2", "password2", "secretAnswer2");
            dataBaseCreds[2] = new Credentials("name3", "password3", "secretAnswer3");
            return dataBaseCreds;
        }
    }
}