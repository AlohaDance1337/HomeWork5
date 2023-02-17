string CreatArray(string massage)
{
    int sum = 0;
    Random rnd = new Random();
    int[] numbers = new int[4];
    int count = 0;

    for(int i = 0; i< numbers.Length; i++)
    {
        numbers[i] = rnd.Next(1,99);
        Console.WriteLine($"Полученный числа в массиве:{numbers[i]}");
            if (i % 2 != 0)
            {
                sum+=numbers[i];
            }    
    
    }
    Console.Write($"Сумма чисел стоящих на нечетной позиции:{sum}");
    return "1";
}

String A = CreatArray("1");
