using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleInheritance
{
    internal class Circle : IPolygon, IColour
    {
        public void CalculateArea()
        {

            Console.WriteLine("Area of circle is 3.14 * radius * radius");
        }

        public void DisplaySides()
        {
            Console.WriteLine("Circle has no sides");
        }

        public void SetColor(string color)
        {
            Console.WriteLine($"Circle is of {color} colour");
        }
    }
    

    }

