// Задача 66: Задайте значения M и N. Напишите программу, 
//которая найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

int SumNatur(int m, int n)
{
    int start = m;
    int end = n;
    if (m > n)
    {
        start = n;
        end = m;
    }
    return (end + start) * (end - start + 1) / 2; // по формуле суммы членов арифметической прогрессии
}
int n = SumNatur(1, 15);
System.Console.WriteLine(n);