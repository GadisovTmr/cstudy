Console.WriteLine ("Введите  число");
int number = Convert.ToInt32(Console.ReadLine ());
int index = 1;
while (index != number+1)
{
if ((index % 2)==0) 
{
    Console.Write (index);
    Console.Write (",");

}
index = index +1;
}

