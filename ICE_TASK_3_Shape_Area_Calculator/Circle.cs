using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICE_TASK_3_Shape_Area_Calculator
{
    class Circle : Shape, ICalculateArea
    {
        public double Radius { get; }

        public Circle(string name, double radius) : base(name)
        {
            this.Radius = radius;
        }

        public double CalculateArea()
        {
            double temp = 0.0;

            temp = Math.PI * Math.Pow(Radius, 2);

            return temp;
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine(CalculateArea().ToString("0.##"));
        }
    }
}
