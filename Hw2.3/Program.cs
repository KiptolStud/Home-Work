System.Console.WriteLine();
    int Number = 645;
    int Number2 = 78;
    int Number3 = 326792;
    System.Console.WriteLine($"Дано число: {Number}");
    if (Number / 100 > 0) 
       System.Console.WriteLine($"Третьей цифрой числа {Number} является цифра {Number / 1 % 10}");
    else System.Console.WriteLine($"У числа {Number} нет третьей цифры");
     System.Console.WriteLine($"Дано число: {Number}");
    if (Number2 / 100 > 0) 
       System.Console.WriteLine($"Третьей цифрой числа {Number2} является цифра {Number2 / 100 % 10}");
    else System.Console.WriteLine($"У числа {Number2} нет третьей цифры");
     System.Console.WriteLine($"Дано число: {Number3}");
    if (Number3 / 100 > 0) 
       System.Console.WriteLine($"Третьей цифрой числа {Number3} является цифра {Number3 / 1000 % 10}");
    else System.Console.WriteLine($"У числа {Number3} нет третьей цифры");