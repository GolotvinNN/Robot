using System;

public class Robot
{
    private Tuple<int, int> coord; // Поле для хранения координат робота
    public string Name { get; set; } // Свойство для имени робота

    public Tuple<int, int> Coordinates
    {
        get { return coord; } 
        set { coord = value; } // Установка новых координат
    }

    public Robot(int x, int y, string name)
    {
        coord = Tuple.Create(x, y); 
        Name = name; 
    }

    public void Move()
    {
        Random random = new Random();
        int direction = random.Next(0, 4); // Генерация случайного направления

        switch (direction)
        {
            case 0:
                Console.WriteLine("Робот двигается вперед");
                coord = Tuple.Create(coord.Item1 + 1, coord.Item2); // Движение вперед по оси X
                break;
            case 1:
                Console.WriteLine("Робот двигается назад");
                coord = Tuple.Create(coord.Item1 - 1, coord.Item2); // Движение назад по оси X
                break;
            case 2:
                Console.WriteLine("Робот двигается налево");
                coord = Tuple.Create(coord.Item1, coord.Item2 - 1); // Поворот налево по оси Y
                break;
            case 3:
                Console.WriteLine("Робот двигается направо");
                coord = Tuple.Create(coord.Item1, coord.Item2 + 1); // Поворот направо по оси Y
                break;
            default:
                break;
        }
    }
}
