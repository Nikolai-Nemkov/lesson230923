// Напишите программу, которая принимает на вход трехзначное число 
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int Prompt(string message);
{
    Console.WriteLine(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int GetThirdRank(int number)
{
    while (number > 999)
    {
       number /= 10;
     
    }
    return number % 10;
}

bool ValidateNumber(int number)
{
    if (number < 100)
    {
        Console.WriteLine(Третьей цифры нет);
        return false;
    }
    return trie;
}

int number = Prompt("Введите число > ");
if (ValidateNumber(number))
{
    Console.WriteLine(GetThirdRank(number));
}


