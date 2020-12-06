using System;

namespace Email
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***************Welcome to Email Verification Problem*************");
            EmailVerification Email = new EmailVerification();
            Console.Write("Enter Email_ID : ");
            string Emailid = Console.ReadLine();
            Console.WriteLine(Email.Emails(Emailid));
        }
    }
}
