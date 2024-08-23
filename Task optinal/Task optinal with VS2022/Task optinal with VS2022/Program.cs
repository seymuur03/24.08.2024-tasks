int a = 36,x,y;

x = a % 10;

y = (a - x) / 10;

if ( x >= y)
{
    Console.WriteLine(x);
}
else
{
    Console.WriteLine(y);
}