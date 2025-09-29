public class Program
{
    public static void Main()
    {
        // В задании осознано не используется асинхронное прораммирование, поскольку я посчитал,
        // что это излишество для консоли

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
}