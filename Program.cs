// // Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
 
// Console.Write("Введите число M: ");
// int m = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите число N: ");
// int n = Convert.ToInt32(Console.ReadLine());

// AkkermanFunction(m,n);

// void AkkermanFunction(int m, int n)
// {
//     Console.Write(Akkerman(m, n)); 
// }


// int Akkerman(int m, int n)
// {
//     if (m == 0)
//     {
//         return n + 1;
//     }
//     else if (n == 0 && m > 0)
//     {
//         return Akkerman(m - 1, 1);
//     }
//     else
//     {
//         return (Akkerman(m - 1, Akkerman(m, n - 1)));
//     }
// }


// Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

int[] CreateArray(int size, int min, int max)
{
int[] array = new int[size];
for (int i = 0; i < size; i++)
{
array[i] = new Random().Next(min, max+1);//[min, max] [0, 9]
}
return array;
}

void PrintArray(int[] array)
{
for (int i = 0; i < array.Length; i++)
{
System.Console.Write(array[i] + " ");
}
System.Console.WriteLine();
}

System.Console.WriteLine("Input array size: ");
int size = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input minimal value of arr element: ");
int min = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input maximal value of arr element: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] array = CreateArray(size, min, max);
PrintArray(array);

// Извините, но это все, на что хватило моих моральных сил.
// С математикой я не дружу от слова "совсем".
// Насколько я поняла данный курс являестся ознакомительным и ручным тестировщикам необязателен.
// Прошу понять и простить гуманитария до мозга костей)