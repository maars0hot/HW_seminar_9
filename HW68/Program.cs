// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Введите целое положительное число n:");
int numberN = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите целое положительное число m:");
int numberM = Convert.ToInt32(Console.ReadLine());

int result = Levi(numberN,numberM);
Console.WriteLine($"A({numberN},{numberM}) = {result}");

int Levi(int n,int m)
{
   if (n==0) return m+1;
   if (m == 0) return Levi(n-1,1);
   return Levi (n-1,Levi(n,m-1));
}