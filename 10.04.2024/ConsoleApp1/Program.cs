using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {


            List<GeomFigures> geomFigures = new List<GeomFigures>(); // Создаем список для хранения фигур

            while (true)
            {
                Console.WriteLine("Выберите фигуру:");
                Console.WriteLine("1. Прямоугольник");
                Console.WriteLine("2. Треугольник");
                Console.WriteLine("3. Окружность");
                Console.WriteLine("4. Выйти");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        // Ввод значений для прямоугольника
                        Console.WriteLine("Введите ширину прямоугольника:");
                        double width = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введите высоту прямоугольника:");
                        double height = Convert.ToDouble(Console.ReadLine());
                        Rectangle rectangle = new Rectangle(width, height);
                        geomFigures.Add(rectangle); // Добавляем прямоугольник в список
                        Console.WriteLine($"Площадь прямоугольника: {rectangle.CalculateArea()}");
                        Console.WriteLine($"Периметр прямоугольника: {rectangle.CalculatePerimeter()}");
                        break;
                    case 2:
                        // Ввод значений для треугольника
                        Console.WriteLine("Введите длину стороны A треугольника:");
                        double sideA = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введите длину стороны B треугольника:");
                        double sideB = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Введите длину стороны C треугольника:");
                        double sideC = Convert.ToDouble(Console.ReadLine());
                        Triangle triangle = new Triangle(sideA, sideB, sideC);
                        geomFigures.Add(triangle); // Добавляем треугольник в список
                        Console.WriteLine($"Площадь треугольника: {triangle.CalculateArea()}");
                        Console.WriteLine($"Периметр треугольника: {triangle.CalculatePerimeter()}");
                        break;
                    case 3:
                        // Ввод значения для окружности
                        Console.WriteLine("Введите радиус окружности:");
                        double radius = Convert.ToDouble(Console.ReadLine());
                        Circle circle = new Circle(radius);
                        geomFigures.Add(circle); // Добавляем окружность в список
                        Console.WriteLine($"Радиус окружности: {circle.Radius}");
                        Console.WriteLine($"Площадь окружности: {circle.CalculateArea()}");
                        Console.WriteLine($"Длина окружности: {circle.CalculatePerimeter()}");
                        break;
                    case 4:
                        // Вывод информации о фигурах и завершение программы
                        Console.WriteLine("Информация о фигурах:");
                        foreach (var shape in geomFigures)
                        {
                            Console.WriteLine(shape);
                        }
                        return;
                    default:
                        Console.WriteLine("Неправильный выбор.");
                        break;
                }



                Console.ReadKey();


            }       

        }
    }
}
