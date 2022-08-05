int count = 0, distance = 12000, firstFriendspeed = 1, secondFriendspeed = 2, dogSpeed = 5, friend = 2, time = 0;
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

