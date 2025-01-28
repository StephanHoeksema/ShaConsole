namespace ShaConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
             
            string[] names = { "Stephan Hoeksema", "Piet" };
            /*Console.WriteLine("Hello, welkom " + name); //Concationation
             * Console.WriteLine($"Hello, welkom {name}" ); //Intrapolation
             */ 
            Console.WriteLine("Hello, welkom {0}",names); //Formatted string
            /* 
            * int myAge = 48; 
            * Console.WriteLine(myAge);
            * */

            /*
             * Variables
             */

            string name = string.Empty; //Define so it doesn't have a null value
            int YoB = 0;
            decimal salary;
            char gender;

            /*
             * Output
             */
            Console.WriteLine("Ik wil graag wat informatie van je vastleggen.");
            Console.WriteLine("Your name: ");
            name = Console.ReadLine();
            Console.WriteLine("Year of Birth");
            int YoB = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your name {0}.", name);
            Console.WriteLine("Your age is: " + (2024 - YoB));
            Console.WriteLine("Your retirement starts in " + (YoB + 68 - 2024) + " years.");
            
        }
    }
}
