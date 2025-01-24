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
            Console.WriteLine("Hello, welkom {1}",names); //Formatted string
             /* 
             * int myAge = 48; 
             * Console.WriteLine(myAge);
             * */

            Console.WriteLine("Ik wil graag wat informatie van je vastleggen.");
            Console.WriteLine("Your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Year of Birth");
            int YoB = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your name {0}.", name);
            Console.WriteLine("Your age is: " + (2024 - YoB));
            Console.WriteLine("Your retirement starts in " + (YoB + 68 - 2024) + " years.");
            
        }
    }
}
