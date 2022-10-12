     // Ввод кол-ва эл-оа массива
        int n;
        Console.WriteLine("Введите число элементов массива");
        n = Convert.ToInt16(Console.ReadLine());
     // Объявление одномерного массива
        double [] Data = new double[n];
        int i = 0;
       while (i < n)
        {
           Console.WriteLine("Введите элемент массива");
        // Ввод элементов массива

           Data[i] = double.Parse(Console.ReadLine());
           Console.WriteLine();
           i++;
        }
   // Вывод содержимого массива
     for (i = 0; i < n; i = i + 1)
     Console.WriteLine("Элемент[" + i + "]: " + Data[i]);
     Console.ReadKey();
