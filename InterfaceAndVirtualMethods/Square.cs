using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAndVirtualMethods
{
    class Square : Shape
    {
        private int Side;


        public Square()
        {
            Side = 0;
        }

        public Square(int side)
        {
            Side = side;
        }

        public void SetSide()
        {
            Side = Validator.GetNumber("Please enter the side length (1 - 10000000", 1, 10000000); 
        }

        public int GetSide()
        {
            return Side;
        }


        public override void Draw()
        {
            Console.WriteLine("Hi, I am a square");
        }


        public float GetArea()
        {
            return (Side * Side);
        }


    }
}
