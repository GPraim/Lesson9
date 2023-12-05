// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.

int enterInteger(string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int SumNaturalNumbers(int M, int N){
    if(M == N){
        return +M;
    }

    return M + SumNaturalNumbers(M+1, N);
}

Console.WriteLine(SumNaturalNumbers(enterInteger("Введите число M: "), enterInteger("Введите число N: ")));