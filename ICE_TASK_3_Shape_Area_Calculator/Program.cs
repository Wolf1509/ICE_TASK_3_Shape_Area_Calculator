namespace ICE_TASK_3_Shape_Area_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle R = new Rectangle("Rectange Name", 14.00, 4.00);
            Circle C = new Circle("Circle Name", 12.00);

            R.Display();
            Console.WriteLine();
            C.Display();
        }
    }
}
