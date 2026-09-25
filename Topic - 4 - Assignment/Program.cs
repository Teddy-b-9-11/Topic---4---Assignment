namespace Topic___4___Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            String Username, firstName, lastName, loginName;
            int age, grade, studentNumber;
            double price, averge, number1,number2, number3;

            //part 1
            Console.WriteLine("Hello. What's your name?");
            Username = Console.ReadLine();

            Console.WriteLine("Hi " + Username + "! How old are you?");
            Console.WriteLine(Int32.TryParse(Console.ReadLine(), out age));
            Console.WriteLine("So you're " + age + ", Eh? Thats not that old at all");
            Console.ReadLine();

            Console.WriteLine("So how much do you make, " + Username);
            Double.TryParse(Console.ReadLine(), out price);
            Console.WriteLine(price + "! I hope that's per hour and not per year!");
            
            //part 2
            Console.WriteLine("Please enter your imformtion so I can sell it");
            Console.WriteLine("First name:");
            firstName = Console.ReadLine();
            Console.WriteLine("Last name:");
            lastName = Console.ReadLine();
            Console.WriteLine("Login:");
            loginName = Console.ReadLine();
            Console.WriteLine("Grade:");
            Console.WriteLine(Int32.TryParse(Console.ReadLine(), out grade));
            Console.WriteLine("Student ID:");
            Console.WriteLine(Int32.TryParse(Console.ReadLine(), out studentNumber));
            Console.WriteLine("Average:");
            Double.TryParse(Console.ReadLine(), out averge);
            
            Console.WriteLine("Your information:");
            Console.WriteLine("First name:\t" + firstName);
            Console.WriteLine("Last name:\t" + lastName);
            Console.WriteLine("Login:\t\t" + loginName);
            Console.WriteLine("Grade:\t\t" + grade);
            Console.WriteLine("Student ID:\t" + studentNumber);
            Console.WriteLine("Average:\t" + averge + "%");

            //part 3
            Console.WriteLine("Hello what's your name?");
            firstName = Console.ReadLine();
            Console.WriteLine("Hi, " + firstName + "! How old are you?" );
            Console.WriteLine(Int32.TryParse(Console.ReadLine(), out age));
            Console.WriteLine("Did you know that in five years you will be " + (age + 5) + " years old? And five years ago you were " + (age - 5) + "! Imagine that!");

            //part 4






        }
    }
}
