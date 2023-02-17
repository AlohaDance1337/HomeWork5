string CreatArray(string massage)
{

    Random rnd = new Random();
    int[] numbers = new int[4];
    int count = 0;

    for(int i = 0; i< numbers.Length; i++)
    {
        numbers[i] = rnd.Next(100,999);
        Console.WriteLine($"Полученный числа в массиве:{numbers[i]}");
            if (numbers[i] % 2 == 0)
            {
                count++;
            }    
    
    }
    Console.Write($"Чисел кратных 2:{count}");
    return "1";
}

String A = CreatArray("1");
