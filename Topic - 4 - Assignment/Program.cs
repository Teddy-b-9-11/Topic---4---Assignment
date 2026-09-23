namespace Topic___4___Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            String Username;
            int age;
            double price;

            Console.WriteLine("Hello. What's your name?");
            Username = Console.ReadLine();

            Console.WriteLine("Hi " + Username + "! How old are you?");
            Console.WriteLine(Int32.TryParse(Console.ReadLine(), out age));
            Console.WriteLine("So you're " + age + ", Eh? Thats not that old at all");
            Console.ReadLine();

            Console.WriteLine("So how much do you make, " + Username);
            Double.TryParse(Console.ReadLine(), out price);
            Console.WriteLine(price + "! I hope that's per hour and not per year!");




        }
    }
}
