//Задача 1: Напишите цикл, который принимает на вход два числа (A и B) 
//и возводит число A в натуральную степень B (и в нулевую степень). 
//Использовать свои функции, не использовать Math.Pow
Console.Clear();
System.Console.WriteLine();
int count = 1;
int addNum(string message)
{    
    Console.Write(message);
    string firststring = Console.ReadLine();
    int num = Convert.ToInt32 (firststring);
    return num;
}
int A = addNum("Введите число ");
int B = addNum("Введите степень ");
int result = A;
 if (B == 0) System.Console.WriteLine($"{A} ^ {B} = 1");
        else 
            while (count < B)
                {
                    result = result * A;
                    count++;
                    System.Console.WriteLine($"{A} ^ {B} = {result}");
                }
 System.Console.WriteLine();