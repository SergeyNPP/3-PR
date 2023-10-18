
double FindDistance(double xa, double ya, double xb, double yb)  // ВАЖНО!!! от записи последовательности МЕНЯЕТСЯ РЕЗУЛЬТАТ!
{
    return Math.Round(Math.Sqrt(Math.Pow(xb - xa, 2) + Math.Pow(yb - ya, 2)), 2);
}
System.Console.Write("Input Xa; ");
int xa = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Input Ya; ");
int ya = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Input Xb; ");
int xb = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Input Yb; ");
int yb = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine(FindDistance(xa, ya, xb, yb));