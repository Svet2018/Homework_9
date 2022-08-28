// Задача 66: Задайте значения M и N. 
//Напишите программу, которая найдёт сумму 
//натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30


//1. Решение 1, с помощью цикла.


int rangeOfNumbers (int num1, int num2)
{
    string answer = string.Empty;
    int sum = 0;
    int number1 = num1;
    int number2 = num1;

    if (num1 >= num2)
    {
        while (number1 >= num2)
        {
            answer = $"{answer}{number1} ";
            sum = sum + number1;
            number1--;
        }
    }
    else if (num1 <= num2)
    {
        while (number1 <= num2)
        {
            answer = $"{answer}{number1} ";
            sum = sum + number1;
            number1++;
        }
    }
    
    System.Console.Write($"Определены числа: {answer}");
    System.Console.WriteLine();
    System.Console.WriteLine($"Сумма натуральных элементов в промежутке от {num1} до {num2} равна: ");
    return sum; 
}

System.Console.WriteLine($"Введите первое число М: ");
int number1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"Введите второе число N: ");
int number2 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine(rangeOfNumbers(number1, number2));
System.Console.WriteLine();


//2. Вариант решения с рекурсией


int rangeOfNaturalNumbers (int numStart, int numEnd)
{
    int sum = numEnd;
    if (numStart <= numEnd) return rangeOfNaturalNumbers(numStart, numEnd -1) + sum;   
    else return 0;
}

System.Console.WriteLine($"Введите два целых числа, первое меньше второго.");
System.Console.WriteLine();
System.Console.WriteLine($"Введите первое число M: ");
int startNum = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"Введите второе число N: ");
int endtNum = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine();
System.Console.WriteLine($"Сумма натуральных элементов в промежутке от {startNum} до {endtNum} равна: ");
System.Console.WriteLine(rangeOfNaturalNumbers(startNum, endtNum));

