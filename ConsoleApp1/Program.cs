string input = Console.ReadLine();

int numberOfCube = int.Parse(input);

double v = Math.Pow(numberOfCube, 3);
double s = 4*Math.Pow(numberOfCube, 2);

Console.WriteLine("Объем куба: " + v);
Console.WriteLine("Площадь боковой поверхности: " + s);