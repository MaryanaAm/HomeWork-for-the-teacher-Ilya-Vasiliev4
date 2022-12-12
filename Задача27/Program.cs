// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11  
// 82 -> 10
// 9012 -> 12

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

 int Result(int number)
 {
    int summ = 0;
    while (number > 0)
    {
        summ += number % 10;
        number /= 10;
    }
    return summ;
 }

Console.WriteLine("Сумма чисел равна: " + Result(GetNumber("Для вычисления суммы цифр, введите число больше 0:")));



