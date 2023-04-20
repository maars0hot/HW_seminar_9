// Задача 66: Задайте значения M и N. Напишите программу, 
//которая найдёт сумму натуральных элементов в промежутке от M до N.
//Выполнить с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите целое положительное число M:");
int numberM = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите целое положительное число N:");
int numberN = Convert.ToInt32(Console.ReadLine());

if (numberM < numberN) 
{
    Console.WriteLine($"{SumNumbers(numberM, numberN)}");
}
else Console.WriteLine($"{SumNumbers(numberN, numberM)}");



int SumNumbers(int M, int N)
{
    if (N + 1 == M) return 0;
    return M + SumNumbers(M + 1, N);
}