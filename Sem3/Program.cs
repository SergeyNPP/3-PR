int FindQuards(int x, int y)

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

{
    if (x > 0 && y > 0) return 1;
    else if (x < 0 && y > 0) return 2;
    else if (x < 0 && y < 0) return 3;
    else if (x > 0 && y < 0) return 4;
    System.Console.WriteLine("The point lies on line!");
    return 0;
}

System.Console.Write("Input X; ");
int x = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Input Y; ");
int y = Convert.ToInt32(Console.ReadLine());
int result = FindQuards(x, y);
System.Console.WriteLine($"The point located at {result} quart");