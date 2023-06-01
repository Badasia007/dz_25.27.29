//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

Console.Clear();
Console.WriteLine("Введите число которое хотите возвести в степень:  ");
int number1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите степень:  ");
int number2 = int.Parse(Console.ReadLine());

long StepenNumbers(int n, int n2){
    int i = 1;
    long result = 1;
    while (number2 >= i)
    {
        result = result * number1;
        i++;
    }
    return result;
}
Console.WriteLine($"Число {number1} в степени {number2} равно {StepenNumbers(number1, number2)}!");