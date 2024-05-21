namespace Assignment3._2._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input radius of circle A");
            Circles A = new Circles(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine("Input radius of circle B");
            Circles B = new Circles(Convert.ToDouble(Console.ReadLine()));
            double totalArea = A + B;
            double areaDifference = A - B;

        }
    }

    public class Circles
    {
        public double Radius { get; set; }
        public double Area { get; set; }
        public Circles(double radius)
        {
            Radius = radius;
            Area = radius * radius * 3.14;
        }
        public static double operator +(Circles a, Circles b)
        {
            double totalArea = a.Area + b.Area;
            Console.WriteLine($"The total area of the two circles is {totalArea}");
            return totalArea;
        }
        public static double operator -(Circles a, Circles b)
        {
            double areaDifference = a.Area - b.Area;
            Console.WriteLine($"The total area difference of the two circles is {areaDifference}");
            return areaDifference;
        }
    }
}
