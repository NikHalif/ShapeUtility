using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapeUtility.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeUtility.Models.Tests
{
    [TestClass()]
    public class TriangleTests
    {
        [TestMethod()]
        [DataRow(40, 20, 30)]
        [DataRow(18, 35.1, 19)]
        [DataRow(0.7, 0.8, 1.3)]
        public void TriangleTest(double a, double b, double c)
        {
            var triangle = new Triangle(a, b, c);
            Assert.IsFalse(triangle == null);
        }

        [TestMethod()]
        [DataRow(40, 20, 30, 290.47)]
        [DataRow(18, 35.1, 19, 102.66)]
        [DataRow(0.7, 0.8, 1.3, 0.24)]
        public void AreaTest(double a, double b, double c, double result)
        {
            var triangle = new Triangle(a, b, c);
            var area = Math.Round(triangle.Area(), 2);
            Assert.IsFalse(area != result, $"Площадь фигуры со сторонами `{a}`,`{b}`,`{c}` неверна!\nВычеcлено: `{area}`, должно быть: `{result}`.");
        }

        [TestMethod()]
        [DataRow(40, 20, 30, 90)]
        [DataRow(18, 35.1, 19, 72.1)]
        [DataRow(0.7, 0.8, 1.3, 2.8)]
        public void PerimeterTest(double a, double b, double c, double result)
        {
            var triangle = new Triangle(a, b, c);
            var perimeter = Math.Round(triangle.Perimeter(), 2);
            Assert.IsFalse(perimeter != result, $"Периметр фигуры со сторонами `{a}`,`{b}`,`{c}` неверна!\nВычеcлено: `{perimeter}`, должно быть: `{result}`.");
        }

        [TestMethod()]
        [DataRow(5, 12, 13, true)]
        [DataRow(40, 20, 30, false)]
        public void IsRectangularTest(double a, double b, double c, bool result)
        {
            var triangle = new Triangle(a, b, c);
            var isRectangular = triangle.IsRectangular();
            Assert.IsFalse(isRectangular != result, $"Неверное утверждение для треугольника!\n" +
                $"Вычесленно: {(isRectangular ? "прямоугольный":"обчный")}, а по факту: {(result ? "прямоугольный" : "обчный")}");
        }
    }
}