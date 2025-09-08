//е) a^2 , a^5 , a^17 за шесть операций.
//a^2 == a*1*1*1*1*1*a
//a^5 == a*a*a*a*a*1
//a^17 ==:
string a = Console.ReadLine();
double a = int.Parse(a);

double a2 = a * a;
double a4 = a2 * a2;
double a8 = a4 * a4;
double a16 = a8 * a8;
double a17 = a16 * a;