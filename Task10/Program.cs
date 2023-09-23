// Напишите программу, которая на вход принимает
// 3х значное число и на выходе показвает вторую цифру
// этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int Prompt(string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}
int number = Prompt("Введите 3x значное число> ");
if (number < 100 || number >= 1000)
{
    Console.WriteLine("Вы ввели не 3х значное число, повторите ввод");
    return;
}

Console.WriteLine($"Введенное число '{number}'");
int secondRank = number / 10 % 10;
Console.WriteLine($"вторая цифра '{secondRank}'");
