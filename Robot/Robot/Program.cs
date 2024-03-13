class Program
{
    static void Main()
    {
        Robot robot = new Robot(0, 0, "Robot1"); // Создание робота с начальными координатами и именем
        for (int i = 0; i <10; i++)
        {
            robot.Move(); // Вызов метода для перемещения робота
            Console.WriteLine($"Новые координаты: {i + 1}:( {robot.Coordinates.Item1}, {robot.Coordinates.Item2})"); // Вывод новых координат

        }
        
    }
}
