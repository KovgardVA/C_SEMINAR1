int Prompt(string message)
{
    Console.WriteLine(message);
    string inputString = Console.ReadLine();
    int number = Convert.ToInt32(inputString);
    return number;
}

int number = Prompt("Введите число:");
int square = number * number;

Console.WriteLine($"Квадрат числа {number} равен {square}");