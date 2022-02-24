/*
// Задача 1.
Console.Write("Введите целое число ");
int value = Convert.ToInt32(Console.ReadLine());
int kvadrat_value = value * value;
Console.Write("Квадрат данного числа равен ");
Console.WriteLine(kvadrat_value);
*/

/*
// Задача самостоятельно 1.
Console.Write("Введите первое число ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число ");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 == number2 * number2)
{
    bool v = true;
    Console.Write(v);
}
else
{
    bool v = false;
    Console.Write(v);
}
*/

Console.Write("Введите целое число от 1 до 7 ");
int week_day = Convert.ToInt32(Console.ReadLine());
if (week_day == 1)
{
    Console.Write("Понедельник");
}
if (week_day == 2)
{
    Console.Write("Вторник");
}
if (week_day == 3)
{
    Console.Write("Среда");
}
if (week_day == 4)
{
    Console.Write("Четверг");
}
if (week_day == 5)
{
    Console.Write("Пятница");
}
if (week_day == 6)
{
    Console.Write("Суббота");
}
else
{
    Console.Write("Завтра на работу!");
}