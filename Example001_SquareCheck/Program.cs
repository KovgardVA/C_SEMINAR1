// Являются ли введенные числа квадратами друг друга

// int Prompt(string message)
// {
//     Console.WriteLine(message);
//     string inputString = Console.ReadLine();
//     int number = Convert.ToInt32(inputString);
//     return number;
// }

// int number = Prompt("Введите первое число:");
// int square = number * number;

// number = Prompt("Введите второе число:");

// if(square == number)
// {
//     Console.WriteLine("Второе число является квадратом первого!");
// }
// else
// {
//     Console.WriteLine("Второе число не является квадратом первого!");
// }

Console.WriteLine("Введите первое число:");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе чисто:");
int secondNumber = int.Parse(Console.ReadLine() ?? "0");

if (firstNumber == secondNumber * secondNumber)
{
    Console.WriteLine($"Число {firstNumber} является квадратом числа {secondNumber}.");
}
else if (secondNumber == firstNumber * firstNumber)
{
    Console.WriteLine($"Число "+secondNumber+" является квадратом числа "+firstNumber+".");
}
else
{
    Console.WriteLine("Число не являются квадратами друг друга!");
}