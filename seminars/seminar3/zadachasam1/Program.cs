//программа по заданному номеру четверти показывает диапозон
// возможных координат четверти (х и у)
/*
System.Console.WriteLine("Vvedi nomer chetverti: ");
int X = int.Parse(Console.ReadLine());

switch(X)
{
    case 1:
    System.Console.WriteLine("x > 0; y > 0");
    break;
    
    case 2:
    System.Console.WriteLine("x < 0; y > 0");
    break;
    
    case 3:
    System.Console.WriteLine("x > 0; y < 0");
    break;
    
    case 4:
    System.Console.WriteLine("x < 0; y < 0");
    break;

    default:
     System.Console.WriteLine("Nevernoe chislo");
   break;
}
*/

//программа принимает на вход координаты двух точек и находит
//расстояние между ними
/*
System.Console.WriteLine("Vvedi xa: ");
double xa = double.Parse(Console.ReadLine());

System.Console.WriteLine("Vvedi ya: ");
double ya = double.Parse(Console.ReadLine());

System.Console.WriteLine("Vvedi xb: ");
double xb = double.Parse(Console.ReadLine());

System.Console.WriteLine("Vvedi yb: ");
double yb = double.Parse(Console.ReadLine());

double x = Math.Sqrt(Math.Pow(xb - xa, 2) + Math.Pow(yb - ya, 2));

System.Console.WriteLine(Math.Round(x, 2, MidpointRounding.ToNegativeInfinity));
*/

// программа принимает на вход число (N) и выдает 
// таблицу квадратов чисел от 1 до N
// 5 -> 1, 4, 9, 16, 25
/*
System.Console.WriteLine("Vvedi chislo N: ");
int x = int.Parse(Console.ReadLine());

for (int i = 1; i <= x; i++)
{
    if (i == x)
    {
         System.Console.Write(i * 1);
         break;

    }
    System.Console.Write(i * i + ", ");
}
*/
System.Console.WriteLine("Vvedi chislo N: ");
int x = int.Parse(Console.ReadLine());

for (int i = 1; i <= x; i++)
{
   
         System.Console.WriteLine($"kvadrat {i} = {i*i}");
}