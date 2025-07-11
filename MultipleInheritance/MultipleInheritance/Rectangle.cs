using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleInheritance
{
    public class Rectangle : IPolygon, IColour
    {
        public void CalculateArea()
        {
            Console.WriteLine("Area is length * breadth");
        }
        public void DisplaySides()
        {
            Console.WriteLine("Rectangle has 4 sides");
        }

        public void SetColor(string colour)
        {
            Console.WriteLine($"Rectangle is of {colour} color");
        }
    }



    }

