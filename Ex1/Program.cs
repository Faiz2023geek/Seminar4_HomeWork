//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16
Console.Clear();

Console.WriteLine("Введите число A:");
int numberA = GetIntInput();
Console.WriteLine("Введите число B:");
int numberB = GetIntInput();
int result = naturalDegree(numberA, numberB);

int GetIntInput()
{
    string input = Console.ReadLine();
    int result = int.Parse(input);
    return result;
}
int naturalDegree(int firstNumber, int secondNumber)
{
    int degree = firstNumber;
    for (int i = 1; i < secondNumber; i++)
    {
        degree = degree * firstNumber;
    }
    return degree;
}

Console.WriteLine($"{numberA} в степени {numberB} = {result}");