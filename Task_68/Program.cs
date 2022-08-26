// Задача 68: Напишите программу вычисления 
//функции Аккермана с помощью рекурсии.
//Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 29
//Для положительных чисел функция Аккермана вычислаяется: А(m,n) = A(m-1, A(m, n-1))

/*
int AckermannFunction (int numM, int numN)
{
    if (numM == 0)
    { 
        return numN + 1;
    }
    else if (numM > 0 && numN == 0)
    {
        return AckermannFunction(numM - 1, 1);
    }
    else
    {
        return AckermannFunction(numM - 1, AckermannFunction(numM, numN - 1));   
    }
}

long AckermannFunction (long numM, long numN)
{
    if (numM == 0)
    { 
        return numN + 1;
    }
    else if (numM > 0 && numN == 0)
    {
        return AckermannFunction(numM - 1, 1);
    }
    else
    {
        return AckermannFunction(numM - 1, AckermannFunction(numM, numN - 1));   
    }
}
*/



ulong AckermannFunction (ulong numM, ulong numN)
{
    if (numM == 0)
    { 
        return numN + 1;
    }
    else if (numM > 0 && numN == 0)
    {
        return AckermannFunction(numM - 1, 1);
    }
    else
    {
        return AckermannFunction(numM - 1, AckermannFunction(numM, numN - 1));   
    }
}

System.Console.WriteLine($"Введите первое число M: ");
ulong startNum = Convert.ToUInt64(Console.ReadLine());
System.Console.WriteLine($"Введите второе число N: ");
ulong endtNum = Convert.ToUInt64(Console.ReadLine());

System.Console.Write($"Значение функции Аккермана равно: ");
System.Console.WriteLine(AckermannFunction(startNum, endtNum));