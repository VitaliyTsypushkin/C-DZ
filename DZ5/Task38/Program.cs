void FillArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-100, 100); //[-9, 10)}
}

void PrintArray(double[] array)
{
    foreach (var item in array)
        Console.Write($"{item} ");
    System.Console.WriteLine();
}


Console.WriteLine("введите размерность массива: ");
int i = Convert.ToInt32(Console.ReadLine());
double[] array = new double[i];


FillArray(array);
PrintArray(array);

double max = array[0];
double min = array[0];
for (int j = 0; j < array.Length; j++)
{
    if (array[j] > max)
    {
        max = array[j];
    }
}
for (int j = 0; j < array.Length; j++)
{
    if (array[j] < min)
    {
        min = array[j];
    }
}
System.Console.WriteLine(max - min);
