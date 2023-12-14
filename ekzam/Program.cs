// ЗАДАЧА 1

// Задайте значения A и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от A до N. 
// Использовать рекурсию, не использовать циклы.

System.Console.Write("Введите значение М: ");
int A = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите значение N: ");
int B = Convert.ToInt32(Console.ReadLine());
void Numbers (int A)
{
    if (A <= B)
    {
        Console.Write("{0} ", A);
        Numbers(A + 1);
    }
}
Numbers(A);
