// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. Решение 2
/*
564 -> 5
782 -> 8
918 -> 1
*/
/*
int SecondSymbol(int number)
{
    int result = number % 100 / 10;
    return result;
}

Console.WriteLine("Input a three-digit integer: ");
int num = Convert.ToInt32(Console.ReadLine());
int secondSymbol = SecondSymbol(num);
Console.WriteLine($"Second symbol of {num} is {secondSymbol}");
*/

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа.
/*
645 -> 5
32679 -> 6
21 -> -1
*/

/*
int ThirdSymbol(int num)
{
    int max = 1000;
    int min = 100;
    int result = 0;

    while(num > max)
        {
            num = num / 10;
        }
    if(num > min)
        {
            result = num % 10;
        }
        else
        {
            result = -1;
        }   
return result;
}

Console.Write("Input integer number:  ");
int num = Convert.ToInt32(Console.ReadLine());

int thirdSymbol = ThirdSymbol(num);
Console.WriteLine($"The third symbol of number {num} is {thirdSymbol}");
*/


// ----------------------------------------------------------------
// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
/*
6 -> да
7 -> да
1 -> нет
*/
/*
bool NumberDayOfWeek(int num)
{
    if(num == 6 || num == 7)
    {
        return true;
    }
    else
    {
        return false;
    }
}

Console.Write("Input a number day of week: ");
int num = Convert.ToInt32(Console.ReadLine());
bool result = NumberDayOfWeek(num);
Console.WriteLine(result);
*/