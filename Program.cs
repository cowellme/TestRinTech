using System.Reflection;
using System.Runtime.CompilerServices;
using TestRinTech;

public class Program
{
    public static void Main()
    {
        // В задании осознано не используется асинхронное прораммирование, поскольку я посчитал,
        // что это излишество для консоли
        
        
        Console.WriteLine("1 - Лифт\n" +
                          "2 - Математика\n" +
                          "3 - Возрасты");

        if (int.TryParse(Console.ReadLine(), out var cmd))
        {
            switch (cmd)
            {
                case 1: Elevator(); break;
                case 2: RinMaths(); break;
                case 3: Years(); break;
                default: Elevator(); break;
            }
        }
    }

    private static void Elevator()
    {
        var elevator = new Elevator(-3, 26);
        var isWork = true;
        while (isWork)
        {
            var command = Console.ReadLine();
            if (int.TryParse(command, out var floor))
            {
                var result = elevator.move(floor);
                Console.WriteLine(result ? "Успешно\n" : "Этаж не доступен\n");
            }
            else if (command == "e")
            {
                isWork = false;
            }
        }
    }

    private static void RinMaths()
    {
        var isWork = true;
        while (isWork)
        {
            Console.WriteLine("1. Площадь кругат\n" +
                              "2. Площадь треугольника\n" +
                              "3. Объём шара\n" +
                              "4. Проверка треугольника\n\n" +
                              "Введите что надо расчитать: ");
            var command = Console.ReadLine();
            double result = .0;
            switch (command)
            {
                case "1":
                    var data1 = parseOneNumber();
                    result = RinMath.circleArea(data1);
                    Console.WriteLine($"Площадь круга: {result}\n");
                    break;
                case "2":
                    var data2 = parseThreeNumber();
                    result = RinMath.triangleArea(data2[0], data2[1], data2[2]);
                    Console.WriteLine($"Площадь три-ка: {result}\n");
                    break;
                    
                case "3": 
                    var data3 = parseOneNumber();
                    result = RinMath.sphereVolume(data3);
                    Console.WriteLine($"Объем сферы: {result}\n");
                    break;
                case "4":
                    var data4 = parseThreeNumber();
                    Console.WriteLine($"{RinMath.validTriangle(data4[0], data4[1], data4[2])}\n");
                    break;

            }
        }
    }

    private static double parseOneNumber()
    {
        if (double.TryParse(Console.ReadLine(), out var result))
        {
            return result;
        }
        throw new Exception("Ошибка ввода");

    }
    private static List<double> parseThreeNumber()
    {
        var listResult = new List<double>();
        var strs = Console.ReadLine()?.Split(",").ToList();
        if (strs != null)
        {
            foreach (var str in strs)
            {
                if (double.TryParse(str, out var result))
                {
                    listResult.Add(result);
                }
                
            }

            if (listResult.Count == 3) return listResult;
        }
        throw new Exception("Ошибка ввода");
    }



    private static void Years()
    {
        var main = new Main();
        main.main();
    }
}