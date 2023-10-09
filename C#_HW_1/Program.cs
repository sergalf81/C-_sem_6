int PosNum(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        count++;
    }
    return count;
}

int[] inputInt(int M)
{
    int[] array = new int[M];
    for(int i = 0; i < M; i++)
    {
        System.Console.Write("Введите целое число: ");
        array[i] = int.Parse(Console.ReadLine());
    }
    return array;
}
System.Console.Write("Введите кол-во целых чисел: ");
int M = int.Parse(Console.ReadLine());
int[] array = inputInt(M);
System.Console.WriteLine($"Ввели {PosNum(array)}  положительных чисел");