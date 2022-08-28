﻿// //Задача 64: Задайте значения M и N. 
//Напишите программу, которая выведет 
//все натуральные числа в промежутке от M до N.
//M = 1; N = 5. -> ""1, 2, 3, 4, 5""
//M = 4; N = 8. -> ""4, 6, 7, 8""

//1. Вариант решения с циклом


void rangeOfNumbers (int num1, int num2)
{
    string answer = string.Empty;

    if (num1 >= num2)
    {
        while (num1 >= num2)
        {
            answer = $"{answer}{num1} ";
            num1--;
        }
    }
    else if (num1 <= num2)
    {
        while (num1 <= num2)
        {
            answer = $"{answer}{num1} ";
            num1++;
        }
    }
    
    System.Console.Write($"Вывод чисел: {answer}");
    System.Console.WriteLine();
}


System.Console.WriteLine($"Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

rangeOfNumbers(number1, number2);
System.Console.WriteLine();


//2. Вариант решения с рекурсией


string rangeOfNaturalNumbers (int numStart, int numEnd)
{   
    if (numStart <= numEnd) return rangeOfNaturalNumbers(numStart, numEnd - 1) + $"{numEnd} ";
    else return string.Empty;    
}


System.Console.WriteLine($"Введите первое число: ");
int startNum = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"Введите второе число: ");
int EndtNum = Convert.ToInt32(Console.ReadLine());

int num1 = startNum;
int num2 = EndtNum;

int num = startNum;

if (startNum > EndtNum)
{
    startNum = EndtNum;
    EndtNum = num;
}


string answer = rangeOfNaturalNumbers(startNum, EndtNum);
int length = answer.Length;


if (num1 <= num2) 
{
    answer = answer.Substring(0,  length-1);
}
else    
{
    answer = answer.Substring(0,  length-1);
    string str = new string(answer.ToCharArray().Reverse().ToArray());
    answer = str;   
}

System.Console.WriteLine($"Вывод чисел: {answer}");
