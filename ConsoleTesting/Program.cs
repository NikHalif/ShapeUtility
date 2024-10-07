using ShapeUtility.Abstraction;
using ShapeUtility.Models;

namespace ConsoleTesting
{
    internal class Program
    {
        static void Main()
        {
            IFigure Circle = new Circle(35);
            IFigure Triangle = new Triangle(12, 5, 13);

            List<IFigure> figures = [Circle, Triangle];

            foreach (IFigure figure in figures)
            {
                Console.WriteLine($"Фигура: {figure.GetType().Name}\nПлощадь: {figure.Area()}\nПериметр: {figure.Perimeter()}");

                if (figure.GetType() == typeof(Triangle))
                {
                    var triangle = (Triangle)figure;
                    Console.WriteLine($"Прямоугольный: {(triangle.IsRectangular() ? "Да":"Нет")}");
                }
            }

        }
    }
}
