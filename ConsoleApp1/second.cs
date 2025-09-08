string a = Console.ReadLine();
string b = Console.ReadLine();

int numA = int.Parse(a);
int numB = int.Parse(b);

Console.WriteLine("Среднее арифметическое");
Console.WriteLine((numA + numB) / 2);
Console.WriteLine("Среднее геометрическое");
Console.WriteLine(Math.Sqrt(numA * numB));