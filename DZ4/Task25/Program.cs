int Degree(int arg1, int arg2)
  { 
    int num  = 1;
           for (int i = 1; i <= arg2; i++)
    {
    num *= arg1;
    }
    return(num);
  }
Console.Clear();
Console.WriteLine("введите число А: ");
int arg1 = int.Parse(Console.ReadLine());
Console.WriteLine("введите число B: ");
int arg2 = int.Parse(Console.ReadLine());
Console.WriteLine($"Число {arg1} в степени {arg2} равно {Degree(arg1, arg2)}");
