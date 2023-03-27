// Программа принимает 3 числа и выдает какое число больше - max

//Получение входных чисел от пользователя и присвоение их в программу
Console.Write("Введи первое целое число: ");

int numbera = int.Parse(Console.ReadLine());

Console.Write("Введи второе целое число: ");

int numberb = int.Parse(Console.ReadLine());

Console.Write("Введи третье целое число: ");

int numberc = int.Parse(Console.ReadLine());

int max_num = numbera;

// Сравнение входных чисел - так и не решил

if(numberb > max_num) 
{
    max_num = numberb;
    }
if(numberc > max_num)
{
    max_num = numberc;
}

    Console.WriteLine($"Наибольшее число - {max_num}");
