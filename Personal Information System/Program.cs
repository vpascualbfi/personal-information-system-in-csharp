namespace Personal_Information_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            int age;
            double height;

            Console.WriteLine("Welcome to Your Personal Information System!\n");

            Console.Write("Please enter your name: ");
            // reads input from the user and assigns it to the variable 'name'
            name = Console.ReadLine();

            Console.Write("Please enter your age: ");
            // if the input is not a valid integer or is negative, it asks the user to input their age again
            while (!int.TryParse(Console.ReadLine(), out age) || age < 0)
            {
                Console.Write("\nInvalid input. Age must be a positive number.\nPlease enter your age: ");
            }

            Console.Write("Please enter your height in meters: ");
            // if the input is not a valid number or is negative, it asks the user to input their height again
            while (!double.TryParse(Console.ReadLine(), out height) || height < 0)
            {
                Console.Write("\nInvalid input. Height must be a positive number.\nPlease enter your height: ");
            }

            // converts age, which is of type integer, into a double data type
            double doubleAge = (double)age;
            // defines a constant value for the legal drinking age
            const int legalDrinkingAge = 21;
            // constructs a string containing the name, age in double format, and height
            string personalInfo = $"{name}, {doubleAge} {(doubleAge > 1 ? "years" : "year")} old, {height} {(height > 1 ? "meters" : "meter")}";

            Console.WriteLine("\n------------------------");
            Console.WriteLine($"Your Personal Details:\nName: {name}\nAge: {doubleAge}\nHeight: {height} {(height > 1 ? "meters" : "meter")}");
            // prints a message based on whether doubleAge is greater than or equal to 18 or not
            Console.WriteLine($"\nAge Check:\n{(doubleAge >= 18 ? $"Welcome, {name}! You're eligible for additional features." : $"{name}, you are still a minor.")}");
            // prints a message indicating whether the user is of legal drinking age based on the comparison of doubleAge and legalDrinkingAge
            Console.WriteLine($"\nLegal Drinking Age Verification:\n{(doubleAge >= legalDrinkingAge ? $"Cheers, {name}! You're legally allowed to enjoy alcoholic beverages." : $"Sorry {name}, you are underage for drinking.")}");
            Console.WriteLine($"\nPersonal Details Presentation:\nYour Personal Information: {personalInfo} tall");
            Console.WriteLine("\n------------------------\nThank you for using your Personal Information System!");

            Console.ReadKey();
        }
    }
}
