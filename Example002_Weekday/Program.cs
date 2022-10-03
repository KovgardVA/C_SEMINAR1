// Найти день недели по введенному номеру

// Console.WriteLine("Введите номер:");
// string weekday = Console.ReadLine();

// if(weekday == "1")
// {
//     Console.WriteLine("Понедельник");
// }
// else if(weekday == "2")
// {
//     Console.WriteLine("Вторник");
// }
// else if(weekday == "3")
// {
//     Console.WriteLine("Среда");
// }
// else if(weekday == "4")
// {
//     Console.WriteLine("Четверг");
// }
// else if(weekday == "5")
// {
//     Console.WriteLine("Пятница");
// }
// else if(weekday == "6")
// {
//     Console.WriteLine("Суббота");
// }
// else if(weekday == "7")
// {
//     Console.WriteLine("Воскресенье");
// }
// else
// {
//     Console.WriteLine("Введено неверное значение!");
// }

Console.WriteLine("Ведите номер дня недели:");
int day = Convert.ToInt32(Console.ReadLine());
string[] days =
{
    "Понедельник",
    "Втоник",
    "Среда",
    "Четверг",
    "Пятница",
    "Суббота",
    "Воскресенье"
};

if (day < 1 || day > 7)
{
    Console.WriteLine("Это не день недели!");
}
else
{
    Console.WriteLine(days[day - 1]);
}

// switch (day)
// {
//     case 1:
//         Console.WriteLine("Понедельник");
//         break;
//     case 2:
//         Console.WriteLine("Вторник");
//         break;
//     case 3:
//         Console.WriteLine("Среда");
//         break;
//     case 4:
//         Console.WriteLine("Четверг");
//         break;
//     case 5:
//         Console.WriteLine("Пятница");
//         break;
//     case 6:
//         Console.WriteLine("Суббота");
//         break;
//     case 7:
//         Console.WriteLine("Воскресенье");
//         break;
// }
