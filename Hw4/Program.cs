//Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

int Prompt(string message)
{    
    Console.Write(message);
    string firststring = Console.ReadLine();
    int value1 = Convert.ToInt32 (firststring);
    return value1;
}
int valuemin = Convert.ToInt32("1");
int value1 = Prompt("Введите количество элементов массива ");
        for (int i = valuemin; i <= value1; i++)
        {
            if (i % 2 == 0) 
            {
                System.Console.WriteLine(i + " ");
            }
        }
   