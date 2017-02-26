using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tiffanys_VirtualPet
{
    class Program
    {
        static void Main(string[] args)
        {
            string petName = string.Empty;

            // user inputs 

            int userInput;

            VirtualPet Gizmo = new VirtualPet();

            Console.WriteLine("What is your gremlins name?");
            petName = Console.ReadLine();
            Console.WriteLine("\n\n" + petName + " likes to eat Jack Frost Donuts, M&M's and drinks RedBull and must remain in the dark at all times");
            do
            {

                Console.WriteLine("\n\nCurrently " + petName + " has:");
                Gizmo.status();
                userInput = int.Parse(Console.ReadLine());

                //else if statements

                if (userInput == 1)
                {
                    Gizmo.feed();
                }
                else if (userInput ==2)
                {
                    Gizmo.thirst();
                }
                
            
                else if (userInput == 3)
            {
                Gizmo.play();
            }
                else
                {
                    Console.WriteLine("Please enter valid input");
                }
            } while (true);


           















        }
    }
}
