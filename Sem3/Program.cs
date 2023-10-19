

// {
//     if (x>0 && y>0)
//     System.Console.WriteLine("Мы в 1 четверти");

//     if (x<0 && y>0)
//     System.Console.WriteLine("Мы в 2 четверти");
    
//     if (x<0 && y<0)
//     System.Console.WriteLine("Мы в 3 четверти");
    
//     if (x>0 && y<0)
//     System.Console.WriteLine("Мы в 4 четверти");
// }



// int FindQuards(int x, int y)

// {
//     if (x > 0 && y > 0) return 1;
//     else if (x < 0 && y > 0) return 2;
//     else if (x < 0 && y < 0) return 3;
//     else if (x > 0 && y < 0) return 4;
//     System.Console.WriteLine("The point lies on line!");
//     return 0;
// }

// System.Console.Write("Input X; ");
// int x = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Input Y; ");
// int y = Convert.ToInt32(Console.ReadLine());
// int result = FindQuards(x, y);
// System.Console.WriteLine($"The point located at {result} quart");




// double FindDistance(double xa, double ya, double xb, double yb)  // ВАЖНО!!! от записи последовательности МЕНЯЕТСЯ РЕЗУЛЬТАТ!
// {
//     return Math.Round(Math.Sqrt(Math.Pow(xb - xa, 2) + Math.Pow(yb - ya, 2)), 2);
// }
// System.Console.Write("Input Xa; ");
// int xa = Convert.ToInt32(Console.ReadLine());

// System.Console.Write("Input Ya; ");
// int ya = Convert.ToInt32(Console.ReadLine());

// System.Console.Write("Input Xb; ");
// int xb = Convert.ToInt32(Console.ReadLine());

// System.Console.Write("Input Yb; ");
// int yb = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine(FindDistance(xa, ya, xb, yb));

void Kvadrat (int n)
{
    int i = 0;
    while (i<n)
        {
           System.Console.WriteLine($"{i}->{i*i} ");
            i++;
        }
    // int array[] = Convert.
}
System.Console.WriteLine("vvedite");
int n = Convert.ToInt32(Console.ReadLine());
Kvadrat(n);
