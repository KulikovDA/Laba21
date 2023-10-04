//высокий уровень 25
Console.Write("Введите x:");
double x = double.Parse(Console.ReadLine());
Console.WriteLine("Введите y:");
double y = double.Parse(Console.ReadLine());
Console.WriteLine((x >= -1 && y <= x && y < 0) || (x <=1 && y <= -x && y <0));