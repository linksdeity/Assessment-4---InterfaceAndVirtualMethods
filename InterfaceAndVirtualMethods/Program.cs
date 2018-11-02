using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAndVirtualMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //S - Our Square class is only responsible for properties and methods related directly to it
            //O - We extend the Shape class into the Square class instead of just modfying Shape
            //L - We override the parent method in Draw() for the same functionality buy polymorphed for Square
            //I - Our Square is not given anything it does not need via inheritence (or interfaces if we used that)
            //D - We use abstraction to inherit to our Square class and only depend on the parent class






            Console.WriteLine("We have a square!\nHow large are the sides?");

            int sides = Validator.GetNumber("Please enter a number 1 - 10000000", 1, 10000000);

            Square userSquare = new Square(sides);

            Console.WriteLine("The area of this square is: {0}", userSquare.GetArea());

            while (true)
            {
                //this second section uses the properties instead of the constructor to access and set the Side length

                Console.WriteLine("Would you like to get the area of a differently sized square?");

                bool answer = Validator.GetAnyCaseChar("Please type 'y' for 'y'es, anything else for no!", 'y', 'Y');

                if (answer)
                {
                    Console.Clear();

                    Console.WriteLine("We have a square!\nHow large are the sides?");

                    userSquare.SetSide();

                    Console.WriteLine("The area of this square is: {0}", userSquare.GetArea());

                    Console.WriteLine("Would you like to get the area of a differently sized square?");

                    answer = Validator.GetAnyCaseChar("Please type 'y' for 'y'es, anything else for no!", 'y', 'Y');

                    if (answer)
                    {
                        continue;
                    }
                    else
                    {
                        break;
                    }

                }
                else
                {
                    break;
                }
            }


            Console.WriteLine("Goodbye!!!");
            Console.ReadKey();


        }
    }
}
