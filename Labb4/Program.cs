namespace Labb4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var c1 = new Circle(5);

            Console.WriteLine($"Arean för radie = 5 : {c1.GetArea(5)} , Omkrets : {c1.GetCircumference(5)}");

            var c2 = new Circle(6);

            Console.WriteLine($"Arean för radie = 6 : {c1.GetArea(6)} , Omkrets : {c1.GetCircumference(6)}");

        }
    }
}
