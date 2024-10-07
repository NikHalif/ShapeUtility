using ShapeUtility.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeUtility.Models
{
    /// <summary>
    /// Экземпляр фигуры треугольника.
    /// </summary>
    public class Triangle : IFigure
    {
        /// <summary>
        /// Создание экземпляра треугольника
        /// </summary>
        /// <param name="a">Первая сторона треугольника</param>
        /// <param name="b">Вторая сторона треугольника</param>
        /// <param name="c">Третья сторона треугольника</param>
        /// <exception cref="ArgumentException"></exception>
        public Triangle(double a, double b, double c) { 
            if(a <= 0 || b <= 0 || c <= 0) throw new ArgumentException("Сторона треугольника не может быть быть равна или меньше 0!");
            if(a + b <= c || 
               a + c <= b ||
               b + c <= a ) throw new ArgumentException("Сумма длин каждых двух сторон должна быть больше длины третьей стороны!");
            A = a; B = b; C = c;
        }
        /// <summary>
        /// Первая сторона треугольника.
        /// </summary>
        public double A { get; set; }
        /// <summary>
        /// Вторая сторона треугольника.
        /// </summary>
        public double B { get; set; }
        /// <summary>
        /// Третья сторона треугольника.
        /// </summary>
        public double C { get; set; }

        /// <summary>
        /// Вычисление площади треугольника
        /// </summary>
        /// <returns>Площадь треугольника</returns>
        public virtual double Area()
        {
            var p = Perimeter()/2;
            return Math.Sqrt(p*(p-A)*(p-B)*(p-C));
        }

        /// <summary>
        /// Вычисление периметра треугольника
        /// </summary>
        /// <returns>Периметр треугольника</returns>
        public virtual double Perimeter()
            => A + B + C;

        public virtual bool IsRectangular()
        {
            if ((A * A + B * B == C * C) ||
                (A * A + C * C == B * B) ||
                (B * B + C * C == A * A)) return true;
            return false;
        }
    }
}
