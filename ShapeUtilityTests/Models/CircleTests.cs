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
    public class CircleTests
    {
        [TestMethod()]
        [DataRow(40)]
        [DataRow(0.5)]
        [DataRow(14.6)]
        public void CircleTest(double radius)
        {
            var circle = new Circle(radius);
            Assert.IsFalse(circle == null);
        }

        [TestMethod()]
        [DataRow(40, 5026.55)]
        [DataRow(0.5, 0.79)]
        [DataRow(14.6, 669.66)]
        public void AreaTest(double radius, double result) 
        {
            var circle = new Circle(radius);
            var area = Math.Round(circle.Area(), 2);
            Assert.IsFalse(area != result, $"Площадь круга с радиусом `{radius}` неверна!\nВычеcлено: `{area}`, должно быть: `{result}`.");
        }

        [TestMethod()]
        [DataRow(40, 251.33)]
        [DataRow(0.5, 3.14)]
        [DataRow(14.6, 91.73)]
        public void PerimeterTest(double radius, double result)
        {
            var circle = new Circle(radius);
            var perimeter = Math.Round(circle.Perimeter(), 2);
            Assert.IsFalse(perimeter != result, $"Периметр круга с радиусом `{radius}` неверна!\nВычеcлено: `{perimeter}`, должно быть: `{result}`.");
        }
    }
}