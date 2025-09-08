string a = Console.ReadLine();
string b  = Console.ReadLine();
int numA = int.Parse(a);
int numB = int.Parse(b);

double gipo = Math.Sqrt(Math.Pow(numA, 2) + Math.Pow(numB,2));
int s = (numA * numB) / 2;
Console.WriteLine("Гипотенуза" + gipo);
Console.WriteLine("Площадь" +  s);