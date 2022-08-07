Console.WriteLine ("Введите первое число");
int first = Convert.ToInt32(Console.ReadLine ());
Console.WriteLine ("Введите  второе число");
int second = Convert.ToInt32(Console.ReadLine ());
Console.WriteLine ("Введите  третье число");
int third = Convert.ToInt32(Console.ReadLine ());

int max = first;

if (max <= second)
{
    max = second;
}
if (max <= third)
{
    max = third;
}
Console.WriteLine ("Максимальное число ");
Console.Write (max);
