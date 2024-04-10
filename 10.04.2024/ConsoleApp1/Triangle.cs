using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // Класс треугольника, реализующий интерфейс GeomFigures
    class Triangle : GeomFigures
    {
        /// <summary>
        /// Длина стороны A треугольника
        /// </summary>
        public double SideA { get; set; }
        /// <summary>
        /// Длина стороны B треугольника
        /// </summary>
        public double SideB { get; set; }
        /// <summary>
        /// Длина стороны С треугольника
        /// </summary>
        public double SideC { get; set; }


        /// <summary>
        /// Конструтор без параметров
        /// </summary>
        public Triangle()
        {
        }

        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        /// <param name="sideA">стороны A треугольника</param>
        /// <param name="sideB">стороны B треугольника</param>
        /// <param name="sideC">стороны С треугольника</param>
        public Triangle(double sideA, double sideB, double sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        /// <summary>
        /// Метод вычисления площади треугольника
        /// </summary>
        /// <returns></returns>
        public double CalculateArea()
        {
            // Формулу Герона для вычисления площади треугольника
            double s = (SideA + SideB + SideC) / 2;
            return Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC)); // Возвращаем площадь треугольника
        }

        /// <summary>
        /// Метод вычисления периметра треугольника
        /// </summary>
        /// <returns></returns>
        public double CalculatePerimeter()
        {
            return SideA + SideB + SideC; 
        }

        /// <summary>
        /// Переопределение метода ToString() для вывода параметров треугольника
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Треугольник: Сторона A = {SideA}, Сторона B = {SideB}, Сторона C = {SideC}, Площадь = {CalculateArea()}, Периметр = {CalculatePerimeter()}";
        }











    }
}
