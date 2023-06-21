//Задача 19
//вход - пятизначное число, вывод - не палиндром ли оно.
Console.Write("Введите целое пятизначное число:  ");
if (!int.TryParse(Console.ReadLine(), out int n))
{
    Console.WriteLine("вы ввели некорректное число");
    return;
}
int cst = n / 10000;
int cdt = n / 1000 % 10;
int cet = n / 100 % 10;
int cs = n / 10 % 10;
int ce = n % 10;
Console.Write(cst == ce | cdt == cs ?
"Число является палиндромом" : "Число НЕ является палиндромом");















//Задача 21
//ввод трехмерных координат двух точек и вывод - расстояние между ними
// Console.WriteLine("Введите коодинату х1: ");
// Double x1 = Double.Parse(Console.ReadLine());
// Console.WriteLine("Введите коодинату y1: ");
// Double y1 = Double.Parse(Console.ReadLine());
// Console.WriteLine("Введите коодинату z1: ");
// Double z1 = Double.Parse(Console.ReadLine());
// Console.WriteLine("Введите коодинату x2: ");
// Double x2 = Double.Parse(Console.ReadLine());
// Console.WriteLine("Введите коодинату y2: ");
// Double y2 = Double.Parse(Console.ReadLine());
// Console.WriteLine("Введите коодинату z2: ");
// Double z2 = Double.Parse(Console.ReadLine());

// Double dist = Math.Round(Math.Sqrt(Math.Pow((x2 - x1), 2) 
// + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2)), 3);
// System.Console.WriteLine(dist);















// Задача 23
// Вход - число N  и вывод - таблица кубов от 1 до N
// System.Console.WriteLine("Введите число: ");
// int n = Int32.Parse(Console.ReadLine()!);
// System.Console.WriteLine($"Таблица кубов чесел от 1 до {n}:");
// for (int i = 1;i <= n; i++)
// {
//     Console.Write($"{(i*i*i)} ");//Console.Write($"{Math.Pow(i,3)} ")
// }
//////////////////////////////////////////////////////////////////////////
