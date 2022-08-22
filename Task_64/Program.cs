// //Задача 64: Задайте значения M и N. 
//Напишите программу, которая выведет 
//все натуральные числа в промежутке от M до N.
//M = 1; N = 5. -> ""1, 2, 3, 4, 5""
//M = 4; N = 8. -> ""4, 6, 7, 8""

//1. Вариант решения с циклом

void rangeOfNumbers (int num1, int num2)
{
    string answer = string.Empty;
    while (num1 <= num2)
    {
        answer = $"{answer}{num1}, ";
        num1++;
    }
    int length = answer.Length;
    System.Console.Write(answer.Substring(0,  length-2));
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
    if (numStart <= numEnd) return rangeOfNaturalNumbers(numStart, numEnd - 1) + $"{numEnd}, ";
    else return string.Empty;    
}

System.Console.WriteLine($"Введите первое число: ");
int startNum = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"Введите второе число: ");
int EndtNum = Convert.ToInt32(Console.ReadLine());

string answer = rangeOfNaturalNumbers(startNum, EndtNum);
int length = answer.Length;
answer = answer.Substring(0,  length-2);
System.Console.WriteLine(answer);
