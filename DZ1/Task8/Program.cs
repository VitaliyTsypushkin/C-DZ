Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = 0;
while (b < (a - 1)) 
{
    b = b + 2;
    Console.Write(" " + b); 
}