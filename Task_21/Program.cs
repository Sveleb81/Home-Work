Console.Write("Введите координаты первой точки: x1 = ");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();
Console.Write("y1 = ");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();
Console.Write("z1 = ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();
Console.Write("Введите координаты второй точки: x2 = ");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();
Console.Write("y2 = ");
int y2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();
Console.Write("z2 = ");
int z2 = Convert.ToInt32(Console.ReadLine());

double distance = Math. Pow((Math. Pow((x2 - x1), 2) + Math. Pow((y2 - y1), 2) + Math. Pow((z2 -z1), 2)), 0.5);

Console.WriteLine();
Console.Write("Расстояние между двумя точками равно: ");
Console.Write(distance);