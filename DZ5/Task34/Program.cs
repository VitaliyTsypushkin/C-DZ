void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(100, 1000); //[-9, 10)}
}

void PrintArray(int[] array)
{
    foreach (var item in array)
        Console.Write($"{item} ");
    System.Console.WriteLine();
}


Console.WriteLine("введите размерность массива: ");
int i = Convert.ToInt32(Console.ReadLine());
int[] array = new int[i];


FillArray(array);
PrintArray(array);

int count = 0;
for (int j = 0; j < array.Length; j++)
{
    if (array[j] % 2 == 0)
        count += count;
}        
System.Console.WriteLine(count);
