Console.WriteLine("Введите трехзначное число.\n Для выхода из программы наберите q затем Enter");
    while(true)
    {
        string input = Console.ReadLine();
        if(!input.Equals("q"))
            Console.WriteLine("{0}->{1}",input, input[1]);
        else
            break;
    }