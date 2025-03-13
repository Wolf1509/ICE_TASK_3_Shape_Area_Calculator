using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICE_TASK_3_Shape_Area_Calculator
{
    class Rectangle : Shape, ICalculateArea
    {
        public double Length { get; }
        public double Width { get; }

        public Rectangle(string name, double length, double width) : base(name)
        {
            this.Length = length;
            this.Width = width;
        }

        public double CalculateArea()
        {
            double temp = 0.0;

            temp = Length * Width;

            return temp;
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine(CalculateArea().ToString("0.##"));
        }
    }
}
