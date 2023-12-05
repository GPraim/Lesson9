// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int enterInteger(string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int FunctionAkkerman(int n, int m){
    if (n < 0 || m < 0) throw new ArgumentOutOfRangeException();
    if (n == 0) return m + 1;
    if (m == 0) return FunctionAkkerman(n - 1, 1);
    return FunctionAkkerman(n - 1, FunctionAkkerman(n, m - 1));
}

Console.WriteLine(FunctionAkkerman(enterInteger("Введите число M: "), enterInteger("Введите число N: ")));