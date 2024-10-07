using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeUtility.Abstraction
{

    public interface IFigure
    {
        /// <summary>
        /// Вычисление площади фигуры
        /// </summary>
        /// <returns>Площадь фигуры</returns>
        abstract double Area();
        /// <summary>
        /// Вычисление периметра фигуры
        /// </summary>
        /// <returns></returns>
        abstract double Perimeter();
    }
}
