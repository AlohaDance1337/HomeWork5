string CreatArray(string massage)
{
    Random rnd = new Random();
    double[] numbers = new double[5];
    double dif = 0;
    double min = numbers[0];

    for(int i = 0; i< numbers.Length; i++)
    {
        numbers[i] = rnd.Next(1,99);
        Console.WriteLine($"Полученный числа в массиве:{numbers[i]}");
        dif = numbers.Max()-numbers.Min();
    }
    Console.Write($"Разница чисел стоящих на нечетной позиции:{dif}");
    return "1";
}

String A = CreatArray("1");
