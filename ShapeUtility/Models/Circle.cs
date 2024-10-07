using ShapeUtility.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeUtility.Models
{
    /// <summary>
    /// Экземпляр фигуры круга.
    /// </summary>
    public class Circle : IFigure
    {
        /// <summary>
        /// Радиус круга.
        /// </summary>
        public double Radius { get; set; }

        /// <summary>
        /// Создание экземпляра круга
        /// </summary>
        /// <param name="raius">Радиус круга</param>
        /// <exception cref="ArgumentException"></exception>
        public Circle(double raius)
        {
            if (Radius < 0) throw new ArgumentException("Радиус круга не может быть отриццательным!", nameof(raius));
            Radius = raius;
        }

        /// <summary>
        /// Вычесление площади круга.
        /// </summary>
        /// <returns>Прощадь круга</returns>
        public virtual double Area()
            => Math.PI * Math.Pow(Radius, 2);
        /// <summary>
        /// Вычисление длины окружности
        /// </summary>
        /// <returns>Периметр круга</returns>
        public virtual double Perimeter()
            => 2 * Math.PI * Radius;
    }
}
