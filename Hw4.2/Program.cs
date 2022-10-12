// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. Функция должна на вход принимать число, а выдавать сумму его цифр
Console.Clear();
int sumDigit = 0;

int inputFun(string message)
{    
    Console.Write(message);
    string firststring = Console.ReadLine();
    int value = Convert.ToInt32 (firststring);
    return value;
}
int value = inputFun("Введите число ");

System.Console.Write($"Сумма цифр числа {value} равна ");

while (value > 0)
{
    int digit = value % 10;
    sumDigit = sumDigit + digit;
    value = value / 10;
}

System.Console.WriteLine(sumDigit);
System.Console.WriteLine();