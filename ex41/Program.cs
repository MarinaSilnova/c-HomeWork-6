// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
Console.WriteLine("Введите количество чисел, n: ");
    int n = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[n];
    int count = 0;
    for (int i = 0; i < n; i++)
    {
        array[i] = Convert.ToInt32(Console.ReadLine());
        if (array[i] > 0)
        count++;
    }
Console.WriteLine("Исходный массив данных: [" + string.Join(", ", array) + "]");
Console.WriteLine(count);

