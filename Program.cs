// --------Домашнее задание к семинару 2---------

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

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа. Решение 2.
/*
645 -> 5
32679 -> 6
21 -> -1
*/
/*
int ThirdSymbol(int num)
{
    int max = 1000;
    int min0 = -1000;
    int min = 100;
    int max0 = -100;
    int result = 0;

    while(num > max || num < min0) num = num / 10;
    if(num > min || num < max0) result = num % 10;
    else result = -1;
return result;
}

Console.Write("Input integer number:  ");
int num = Convert.ToInt32(Console.ReadLine());

int thirdSymbol = ThirdSymbol(num);
Console.WriteLine($"The third symbol of number {num} is {thirdSymbol}");
*/

// ------------ Домашнее задание к семинару 3 --------------
//
// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/*
14212 -> нет
12821 -> да
23432 -> да
*/
/*
bool PalindromeNumber(int num)
{
    if(num % 10 == num / 10000 || num % 100 / 10 == num / 100 % 10)
        return true;
    else
        return false;
}
Console.Write("Input a five-digit integer:  ");
int num = Convert.ToInt32(Console.ReadLine());
bool result = PalindromeNumber(num);
Console.WriteLine(result);
*/

// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
/*
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/
/*
double LineLength (double x1, double x2, double y1, double y2, double z1, double z2)
{
    double LineLength1, LineLength2, LineLength3, result;
    LineLength1 = x2 - x1;
    LineLength2 = y2 - y1;
    LineLength3 = z2 - z1;
    result = Math.Sqrt(Math.Pow(LineLength1,2) + Math.Pow(LineLength2,2) + Math.Pow(LineLength3,2));
    return result;
}

Console.Write("Введите координату X первой точки: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Y первой точки: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Z первой точки: ");
double z1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координату X второй точки: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Y второй точки: ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Z второй точки: ");
double z2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Длина отрезка: " + Math.Round(LineLength(x1, y1, z1, x2, y2, z2) , 2));
*/

// Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N. For.
/*
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/
/*
void Cubes(int num)
{
    for(int i = 1; i <= num; i++)
    {
        Console.Write(i * i * i + "  ");
    }
}
Console.Write("Input a number:  ");
Cubes(Convert.ToInt32(Console.ReadLine()));
*/
// Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N. While.

void Cubes(int num)
{
    int i = 1;

    while(i <= num)
    {
        Console.Write(i * i * i + "  ");
        i = i + 1;
    }

}
Console.Write("Input a integer number:  ");
Cubes(Convert.ToInt32(Console.ReadLine()));


