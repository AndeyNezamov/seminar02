// Напишите программу, которая выводит третью цифру заданного числа.


int Number(int number)
{
    int sot = number;
    while(sot>1000)
    {
        sot = sot / 10;
    }
    int result = sot % 10;
    if (number<100)
    {
        result=-1;
    }
    return result;
}
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int num = Number(number);
Console.WriteLine($"Третья цифра вашего числа: {num}");