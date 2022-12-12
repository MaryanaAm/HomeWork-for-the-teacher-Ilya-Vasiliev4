// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16


int GetNumber(string message)
{
    bool isCorrect = false;
    int result = 0;

    while(!isCorrect)
    {
        Console.WriteLine(message);
        if(int.TryParse(Console.ReadLine(), out result) && result > 0) 
        {
            isCorrect = true;
        }
        else
        {
            Console.WriteLine("Некорректный ввод. ");
        }
    }
    return result;
}

int GetSumm(int a, int b)
{
    int result = 0;
    if(a > 0 && b > 0)
    {
        result = Convert.ToInt32(Math.Pow(a, b));
    }
    return result;
}
int one = GetNumber("Введите число A: ");
int two = GetNumber("Введите число B: ");
Console.WriteLine("Полученное число: " + GetSumm(one, two));


