using System;
using System.Linq;


namespace Initials
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("What is your Full Name?");
            string fullName = Console.ReadLine();           
            Console.WriteLine(Initials(fullName));
            Console.ReadLine();
        }

        public static string Initials(string fullName)
        {

            fullName = fullName.ToUpper();
            string[] FullName = fullName.Split(" ");
            char[] FirstName = FullName[0].ToCharArray();
            char[] MiddleName = FullName[1].ToCharArray();
            char[] LastName = FullName[2].ToCharArray();
            string fullInitials = FirstName[0].ToString();
            fullInitials += MiddleName[0].ToString();
            fullInitials += LastName[0].ToString();

            return fullInitials;
        }          
    }
}
