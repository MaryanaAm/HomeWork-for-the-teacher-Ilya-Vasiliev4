// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

Console.Write("Введите колличество эллементов массива: ");

int arrayLength = int.Parse(Console.ReadLine());

int[] myArray = new int[arrayLength];

for (int i = 0; i < myArray.Length; i++)
{
    Console.WriteLine($"Введите число под индексом {i}: ");
    myArray[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("Вывод массива:");

for (int i = 0; i < myArray.Length; i++)
{
    Console.Write(myArray[i] + " ");
}
