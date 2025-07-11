namespace MultipleInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Choose one from the following : \nRectangle or Circle (r/c) : ");
            string choice = Console.ReadLine();
            if (choice == "r")
            {
                Rectangle rectangle1 = new Rectangle();
                rectangle1.CalculateArea();
                rectangle1.DisplaySides();
                rectangle1.SetColor("red");
            }
            else if (choice == "c")
            {
                Circle circle1 = new Circle();
                circle1.CalculateArea();
                circle1.DisplaySides();
                circle1.SetColor("blue");
            }

        }
    }
}
