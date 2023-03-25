// Программа выдает название дня недели по заданному номеру

//Получение входного числа от пользователя
Console.Write("Введи число от 1 до 7: ");

int number = int.Parse(Console.ReadLine());

// Присваиваем числам дни недели
// вводим условие

switch (number)
{
    case 1:
        Console.Write("Понедельник");
        break;
    case 2:
        Console.Write("Вторник");
        break;
    case 3:
        Console.Write("Среда");
        break;
    case 4:
        Console.Write("Четверг");
        break;
    case 5:
        Console.Write("Пятница");
        break;
    case 6:
        Console.Write("Суббота");
        break;
    case 7:
        Console.Write("Воскресенье");
        break;
    default:
    Console.Write("нет такого дня недели, введи от 1 до 7");
        break;
}