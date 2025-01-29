namespace ShaConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
             
            
            string name = string.Empty; //Define so it doesn't have a null value
            int YoB;
            decimal salary;
            char gender = char.MinValue;
            bool employed = true;

            /*
             * Output
             */
            Console.WriteLine("Ik wil graag wat informatie van je vastleggen.");
            Console.WriteLine("Your name: ");
            name = Console.ReadLine();
            Console.WriteLine("Year of Birth");
            YoB = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your name {0}.", name);
            Console.WriteLine("Your age is: " + (2024 - YoB));
            Console.WriteLine("Your retirement starts in " + (YoB + 68 - 2024) + " years.");

            Console.Write("Your Salary: ");
            salary = Convert.ToDecimal(Console.ReadLine());

            Console.Write("What is your gender: (M,V or N) ");
            gender = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Your Salary is: " + (salary) + "euro");
            Console.WriteLine("Your are a: " + gender);


        }
    }
}
