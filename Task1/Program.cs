/* Задача 64: Задайте значения M и N. Напишите программу, которая выведет все 
чётные натуральные числа в промежутке от M до N с помощью рекурсии. */

int enterInteger(string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

string ShowEvenNumbers(int M, int N){
    
    if(M == N){
        if(M%2 == 0){
            return M.ToString();
        } 
        return String.Empty;
    }
    if(M%2 == 0) {
        return M + " " + ShowEvenNumbers(M+1, N);
    } else {
        return ShowEvenNumbers(M+1, N);
    }
}

Console.WriteLine(ShowEvenNumbers(enterInteger("Введите число M: "), enterInteger("Введите число N: ")));