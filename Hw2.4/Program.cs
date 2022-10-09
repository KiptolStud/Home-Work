int Prompt(string message)
{    
    Console.WriteLine(message);
    string firststring = Console.ReadLine();
    int day = Convert.ToInt32 (firststring);
    return day;
}
int day = Prompt("Введите день недели цифрой от 1 - 7");
     if(day < 6)
     System.Console.WriteLine($"Введеный день {day} является рабочим");
     else if(day == 6)
          System.Console.WriteLine($"Введеный день {day} является выходным");
     else if(day == 7)
          System.Console.WriteLine($"Введеный день {day} является выходным");
     return 0;