// Программа принимает 2 числа и выдает какое число больше, а какое меньше

//Получение входных чисел от пользователя и присвоение их в программу
Console.Write("Введи первое целое число: ");

int numbera = int.Parse(Console.ReadLine());

Console.Write("Введи второе целое число: ");

int numberb = int.Parse(Console.ReadLine());

// Сравнение входных чисел

if(numbera > numberb)
{
    Console.Write("первое число больше второго");
}
else
{
    Console.WriteLine("второе число больше первого числа");
}