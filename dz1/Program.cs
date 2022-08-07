Console.WriteLine ("Введите первое число");
int first = Convert.ToInt32(Console.ReadLine ());
Console.WriteLine ("Введите  второе число");
int second = Convert.ToInt32(Console.ReadLine ());
if (first>second)
{
 Console.Write ("Число ");
 Console.Write (first); 
 Console.Write (" больше");
}
if (first<second)
{
Console.Write ("Число ");
 Console.Write (second); 
 Console.Write (" больше");
}
if (first == second)
{
    Console.WriteLine ("Числа равны");
}