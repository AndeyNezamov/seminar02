//Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.

bool ChekWeekEnd (int day)
{
    bool result = false;
    if (day == 6 || day == 7)
    {
        result = true;
    }
    return result;
}
Console.Write("Введите день недели: ");
int day = Convert.ToInt32(Console.ReadLine());
bool WeekEnd = ChekWeekEnd(day);
Console.WriteLine(WeekEnd);