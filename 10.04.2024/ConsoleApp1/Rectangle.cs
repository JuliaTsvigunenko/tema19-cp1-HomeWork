using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // Класс прямоугольника, реализующий интерфейс GeomFigures
    class Rectangle : GeomFigures
    {
        /// <summary>
        /// Ширина прямоугольника
        /// </summary>
        public double Width { get; set; }
        /// <summary>
        /// Высота прямоугольника
        /// </summary>
        public double Height { get; set; }

        /// <summary>
        /// Конструтор без параметров
        /// </summary>
        public Rectangle()
        {
        }

        /// <summary>
        ///  Конструктор с параметрами
        /// </summary>
        /// <param name="width">ширина прямоугольника</param>
        /// <param name="height">высота прямоугольника</param>
        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        /// <summary>
        /// Метод вычисления площади прямоугольника
        /// </summary>
        /// <returns></returns>
        public double CalculateArea()
        {
            return Width * Height; 
        }

        /// <summary>
        /// Метод вычисления периметра прямоугольника
        /// </summary>
        /// <returns></returns>
        public double CalculatePerimeter()
        {
            return 2 * (Width + Height);
        }

        /// <summary>
        /// Переопределение метода ToString() для вывода параметров прямоугольника
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Прямоугольник: Ширина = {Width}\n Высота = {Height}\n Площадь = {CalculateArea()}\n Периметр = {CalculatePerimeter()}";
        }










    }
}
