// Задача 25
// ввод 2 числа вывод возведение первого в степень второго
// int Degree(int arg1, int arg2)
//   { 
//     int num  = 1;
//            for (int i = 1; i <= arg2; i++)
//     {
//     num *= arg1;
//     }
//     return(num);
//   }
// Console.Clear();
// Console.WriteLine("введите число А: ");
// int arg1 = int.Parse(Console.ReadLine());
// Console.WriteLine("введите число B: ");
// int arg2 = int.Parse(Console.ReadLine());
// Console.WriteLine($"Число {arg1} в степени {arg2} равно {Degree(arg1, arg2)}");
////////////////////////////////////////////////////////////////////////////////
//Задача 27
//ввод числа и вывод суммы цифр числа
// System.Console.WriteLine("Введите число: ");
// int num = int.Parse(Console.ReadLine());
// int sum = 0;
// if (num == 0) sum = 0;
// while (num>0)
// {
//     sum = sum + num % 10;
//     num = num / 10;
//  }
// Console.WriteLine($"Сумма цифр числа = {sum}");
/////////////////////////////////////////////////
//Задача 29
// //задать массив из 8 элементов и вывести на экран сначала 5 элементов и ниже 3 элемента
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
int [] array = new int[num];
FillArray(array);
PrintArray(array);