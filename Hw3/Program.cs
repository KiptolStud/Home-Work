//Задача 3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
int Prompt(string message)

{    
    Console.Write(message);
    string firststring = Console.ReadLine();
    int value1 = Convert.ToInt32 (firststring);
    return value1;
}
int value1 = Prompt("Введите число для проверки четности ");        
        if ((value1  % 2) == 0)
        {
            System.Console.WriteLine($"Число {value1} является четным");
        }
        else
        {
            System.Console.WriteLine($"Число {value1} является нечетным");
        }
