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
/*
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
*/

// ------------ ДОМАШНЕЕ ЗАДАНИЕ К СЕМИНАРУ 4 --------------
//
// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/
/*
double Degree(double num1, double num2)
{
    double result = Math.Pow(num1, num2);
    return result;
}

Console.Write("Введите число:  ");
double num1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите степень:  ");
double num2 = Convert.ToDouble(Console.ReadLine());

double degree = Degree(num1, num2);

Console.WriteLine($"Число {num1} в натуральной степени {num2}: {degree}");
*/

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*
452 -> 11
82 -> 10
9012 -> 12
*/
/*
int SumOfNumbers (int num)
{
    int sum = 0;

    while (num > 0)
    {
        sum = (num % 10) + sum;
        num = num / 10;
    }
    return sum;
}
Console.Write("Input a number:  ");
int num = Convert.ToInt32(Console.ReadLine());
int sumOfNumbers = SumOfNumbers(num);
Console.WriteLine($"Sum of numbers in number is {sumOfNumbers}");
*/


// Задача 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран.
// Массив вводим сами.
/*
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/
/*
void NewArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
    Console.Write("Input element number "+i+" = ");
    array[i] = Convert.ToInt32(Console.ReadLine());
    }
}

void ShowArray(int[] array)
{
    for(int i = 0;  i < array.Length; i++)
    {
        Console.Write(array[i] + "  ");
    }
    Console.WriteLine();
}

int[] array = new int [5];
NewArray(array);
ShowArray(array);
*/


// Задача 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран.
// Случайная генерация.
/*
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/
/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);

    return array;
}

void ShowArray(int [] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + "  ");

    Console.WriteLine();
}

Console.Write("Input a length of new array:  ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value:  ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value:  ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(length, min, max);
ShowArray(myArray);
*/

// ------------ ДОМАШНИЕ ЗАДАНИЕ К СЕМИНАРУ 5 --------------

// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
/*
[345, 897, 568, 234] -> 2
*/
/*
int[] CreateRandomArray(int size)
{
    int[] array = new int[size];

    for(int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(100, 1000);

    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + "  ");

    Console.WriteLine();
}

int CountOfEven(int [] array)
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
        if (array[i] % 2 == 0)
            count++;
    return count;
}

Console.Write("Input a length of new array:  ");
int length = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(length);
ShowArray(myArray);

int countOfEven = CountOfEven(myArray);
Console.WriteLine("Count of even numbers " + countOfEven);
*/

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
/*
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/
/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);

    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + "  ");

    Console.WriteLine();
}

int SumOfUneven(int [] array)
{
    int sum = 0;

    for (int i = 0; i < array.Length; i++)
        if (i % 2 == 0)
            sum += array[i];
    return sum;
}

Console.Write("Input a length of new array:  ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value:  ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value:  ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(length, min, max);
ShowArray(myArray);

int sumOfUneven = SumOfUneven(myArray);
Console.WriteLine("Sum of uneven index is " + sumOfUneven);
/*

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
/*
[3 7 22 2 78] -> 76
*/
// Случайный массив по заданным параметрам пользователя.
/*
void NewArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
    Console.Write("Input element number "+i+" = ");
    array[i] = Convert.ToDouble(Console.ReadLine());
    }
}

void ShowArray(double[] array)
{
    for (int i = 0;  i < array.Length; i++)
    {
        Console.Write(array[i] + "  ");
    }
    Console.WriteLine();
}

double DiffrenceMaxMin(double[] array)
{
    double maxnum = array[0];
    double minnum = array[0];

    for (int i = 0; i < array.Length; i++)
        if (array[i] >= maxnum) maxnum = array[i];
    
    for (int i = 0; i < array.Length; i ++)
        if (array[i] <= minnum) minnum = array[i];
      
    double result = maxnum - minnum;
    return result;
}

double[] array = new double[5];
NewArray(array);
ShowArray(array);
double diffrenceMaxMin = Math.Round((DiffrenceMaxMin(array)),2);
Console.WriteLine("Diffrence between max number and min number is " + diffrenceMaxMin);
*/


// ------------ ДОМАШНИЕ ЗАДАНИЕ К СЕМИНАРУ 6 --------------

// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
/*
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/
/*
void NewArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
    Console.Write("Input element number "+i+" = ");
    array[i] = Convert.ToInt32(Console.ReadLine());
    }
}

void ShowArray(int[] array)
{
    for (int i = 0;  i < array.Length; i++)
    {
        Console.Write(array[i] + "  ");
    }
    Console.WriteLine();
}

int CountPosotivNumbers (int[] array)
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    if (array[i] > 0) count+=1;
    return count;
}

Console.WriteLine("Input 5 numbers");
int[] array = new int[5];
NewArray(array);
ShowArray(array);
int countPosotivNumbers = CountPosotivNumbers(array);
Console.WriteLine("Count of positiv numbers is " + countPosotivNumbers);
*/



// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
/*
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

void IntersectionPoint (double b1, double k1, double b2, double k2)
{
    if (k1 == k2 && b1 == b2)
    Console.WriteLine("Прямые совпадают");
    else if (k1 == k2)
    Console.WriteLine("Прямые параллельны");
    else
    {
    double x = (b2-b1) / (k1-k2);
    Console.WriteLine($"Точка пересечения двух прямых: {x}");
    }
}

Console.Write("Input b1:  ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input k1:  ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input b2:  ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input k2:  ");
double k2 = Convert.ToDouble(Console.ReadLine());

IntersectionPoint (b1, k1, b2, k2);



