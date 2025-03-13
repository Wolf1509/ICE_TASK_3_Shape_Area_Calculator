using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICE_TASK_3_Shape_Area_Calculator
{
    abstract class Shape
    {
        public string Name { get; }

        public Shape(string name)
        {
            this.Name = name;
        }

        public virtual void Display()
        {
            Console.WriteLine("Name ~ " + Name);
        }
    }
}
