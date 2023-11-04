using CircleLab;
using System.Diagnostics.Metrics;
using System.Dynamic;

namespace CircleLab
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool keepGoing = true;
            Console.WriteLine("Welcome to the Circle Tester");
            do
            {
                var radius = GetUsersRadius();
                var circle = new Circle(radius);

                Console.WriteLine($"\nRadius:{circle.GetRadius()}");
                Console.WriteLine($"Diameter: {circle.CalculateDiameter()}");
                Console.WriteLine($"Area: {circle.CalculateArea()}");
                Console.WriteLine($"Circumference: {circle.CalculateCircumference()}\n");
                GetUsersAnswer(circle);
                Console.WriteLine("Would you like to make another circle? Press Y to make another circle or any key to exit.");
                string circleAgain = Console.ReadLine().ToLower();
                if ( circleAgain == "y")
                {
                    keepGoing = true;
                }
                else
                {
                    keepGoing = false;
                    Console.WriteLine("Thank you for using Circle Tester!");
                }


            }
            while (keepGoing == true);           
                

        }
        static void GetUsersAnswer(Circle circle)
        {      
            Console.WriteLine("Should the circle to magically grow? Press Y to continue or any other key to return to Circle Maker.");
            string userInput = Console.ReadLine().ToLower();
            if (userInput == "y")
            {
                Console.WriteLine($"The circle’s final radius is {circle.Grow()}.\n");
            }               
                    
        }
        static double GetUsersRadius ()
        {
            
            double usersRadius = 0;
            bool keepGoing = true;
            do
            {
                try
                {
                    Console.Write($"Please provide the radius of the circle: ");
                    string userNumber = Console.ReadLine();
                    usersRadius = Convert.ToDouble(userNumber);
                    keepGoing = false;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Invalid, please try again.");
                }
            }
            while (keepGoing == true);                  
            
            return usersRadius;
        }
        
    }
}