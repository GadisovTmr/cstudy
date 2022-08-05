int count = 0, friend = 2, time = 0;

Console.WriteLine ("Введите расстрояние");
int distance = Convert.ToInt32(Console.ReadLine ());

Console.WriteLine ("Введите скорость первого друга");
int firstFriendspeed = Convert.ToInt32(Console.ReadLine ());

Console.WriteLine ("Введите скорость второго друга");
int secondFriendspeed = Convert.ToInt32(Console.ReadLine ());

Console.WriteLine ("Введите скорость собаки");
int dogSpeed = Convert.ToInt32(Console.ReadLine ());

while (distance > 10)   
{
  if (friend == 1) 
  {
    time = distance/(firstFriendspeed + dogSpeed);
     friend = 2;
    }
  else
  {
    time = distance/(secondFriendspeed+dogSpeed);
    friend=1;  
  distance = distance - (firstFriendspeed+secondFriendspeed)*time;
  count=count+1;
  }
}
Console.WriteLine ("Собака пробежит" );
Console.Write (count);
Console.Write ("раз");

