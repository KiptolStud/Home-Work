//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
System.Console.Write("Введите пятизначное число:   ");
string number = Console.ReadLine();
int length = number.Length;
string txtToCheck = number.Replace(" ","");  /// для проверки текста на палиндром

bool IsPalindrome()
{
    for (int i = 0; i < length / 2; i++)
        while (number[i] == number[length - 1])
        {
            return true;
        }
    return false;
}

if (IsPalindrome()) System.Console.WriteLine("Да");
else System.Console.WriteLine("Нет");
System.Console.WriteLine();
