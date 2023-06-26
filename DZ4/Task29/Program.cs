void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(1, 50);
}

void PrintArray(int[] array)
{
    foreach (var item in array)
        Console.Write($"{item} ");
    System.Console.WriteLine();
}


Console.Clear();
System.Console.WriteLine("Введите размерность массива ");
int num = Convert.ToInt32(System.Console.ReadLine());
int[] array = new int[num];
FillArray(array);
PrintArray(array);
