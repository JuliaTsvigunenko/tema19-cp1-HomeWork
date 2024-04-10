using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // Класс окружности, реализующий интерфейс GeomFigures
    class Circle : GeomFigures
    {
        /// <summary>
        /// Радиус окружности
        /// </summary>
        public double Radius { get; set; }

        /// <summary>
        /// Конструтор без параметров
        /// </summary>
        public Circle()
        {
        }

        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        /// <param name="radius">Радиус окружности</param>
        public Circle(double radius)
        {
            Radius = radius;
        }

        /// <summary>
        /// Метод вычисления площади окружности
        /// </summary>
        /// <returns></returns>
        public double CalculateArea()
        {
            return Math.PI * Radius * Radius; 
        }

        /// <summary>
        /// Метод вычисления длины окружности
        /// </summary>
        /// <returns></returns>
        public double CalculatePerimeter()
        {
            return 2 * Math.PI * Radius; 
        }

        /// <summary>
        /// Переопределение метода ToString() для вывода параметров окружности
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Окружность: Радиус = {Radius}, Площадь = {CalculateArea()}, Длина окружности = {CalculatePerimeter()}";
        }







    }
}
