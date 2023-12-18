// ЗАДАЧА 1

// Задайте значения A и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от A до N. 
// Использовать рекурсию, не использовать циклы.

// System.Console.Write("Введите значение М: ");
// int A = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Введите значение N: ");
// int B = Convert.ToInt32(Console.ReadLine());
// void Numbers(int A)
// {
//     if (A <= B)
//     {
//         Console.Write("{0} ", A);
//         Numbers(A + 1);
//     }
// }
// Numbers(A);

// ЗАДАЧА 2
// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

// int WorkWithUser(string input)
// {
//     Console.Write(input);
//     int output = Convert.ToInt32(Console.ReadLine());
//     return output;
// }

// int Ack(int m, int n)
// {
//     if (m == 0) return n + 1;
//     else if (n == 0) return Ack(m - 1, 1);
//     else return Ack(m - 1, Ack(m, n - 1));
// }

// int m = WorkWithUser("Введите m: ");
// int n = WorkWithUser("Введите n: ");
// int FunctionAkkerman = Ack(m, n);
// Console.Write($"Функция Аккермана = {FunctionAkkerman} ");


// ЗАДАЧА 3

// Задайте произвольный массив. Выведите его элементы, 
// начиная с конца. Использовать рекурсию, не использовать циклы.

int[] array = new int[6] { 1, 2, 3, 4, 5, 6 };
void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        Console.Write(arr[i] + " ");
    }
}

int[] ReversArray(int[] arr, int index)
{
    if (index <= 0)
    {
        return arr;
    }
    int temp = arr[index];
    arr[index] = arr[arr.Length - index - 1];
    arr[arr.Length - index - 1] = temp;
    return ReversArray(arr, index -= 2);
}
PrintArray(array);
System.Console.WriteLine("\n");
PrintArray(ReversArray(array, array.Length - 1));











