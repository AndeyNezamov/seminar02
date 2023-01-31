/*int CutNumber(int number)
{
    int sot = number / 100;
    int ed = number % 10;

    int result = sot * 10 + ed;
    return result;
}
int num = new Random().Next(100, 1000);
Console.WriteLine(num);
int newNum = CutNumber(num);
Console.WriteLine(newNum);
*/

//Напишите программу, которая получает случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

/*int MaxNumber(int number)
{
    int dec = number/10;
    int ed = number%10;
    int result = dec;
    if (ed>result)
    {
        result = ed;
    }
    return result;
}
int num = new Random().Next(10, 100);

int max = MaxNumber(num);
Console.WriteLine(num);
Console.WriteLine("Maximum number: " + max);
*/

//Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому.
/* bool IsKranto(int num1, int num2)
{
    return tru;
}
*/
bool NumKrat(int number1, int number2)
{
    bool result = false;
    if (number2 % number1 ==0)
    {
        result = true;
    }
    return result;
}
Console.Write("Enter number1: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number2: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(NumKrat(number1, number2));

//Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.


