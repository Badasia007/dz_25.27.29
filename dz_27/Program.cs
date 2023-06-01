//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

Console.Clear();
Console.WriteLine("Введите число :  ");
int number1 = int.Parse(Console.ReadLine());

int SumNumbers(int s){
    int i = -9;
    int sum = 0;
    while (number1 >= i)
    {
        sum = sum + number1%10;
        number1 = number1 /10;
        i++;
    }
    return sum;
    return number1;
}
Console.WriteLine($"В числе {number1} сумма цифр будет равна:  {SumNumbers(5)}!");