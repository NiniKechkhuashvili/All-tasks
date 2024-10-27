// See https://aka.ms/new-console-template for more information
namespace Task1

{
    class Program

    {

        public static void Main(string[] args)
        {

            Console.WriteLine("Information about me");
            string person = "Nini";
            Console.WriteLine("Name " + "- " + person);
            int age = 27;
            Console.WriteLine("Age - " + age);
            Double Height = 1.65;
            Console.WriteLine("Height - " + Height);
            Double Weight = 59.5;
            Console.WriteLine("Weight - " + Weight);
            String gender = "Female";
            Console.WriteLine("Gender - " + gender);
            String MaritalStatus = "Married";
            Console.WriteLine("Marital Status - " + MaritalStatus);
            String Nationality = "Georgian";
            Console.WriteLine("Nationality - " + Nationality);
            DateTime DateOfBirth = new DateTime(1997, 6, 18);
            Console.WriteLine("Date Of Birth - " + DateOfBirth.ToString("dd-MM-yyyy"));
            String EmailAddress = "ninikechkhuashvili1@gmail.com";
            Console.WriteLine("Email Address - " + EmailAddress);
            Double Salary = 500;
            Console.WriteLine("Salary - " + Salary);


        }
    }
}