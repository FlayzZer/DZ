//Напишите программу, которая на вход
//принимает натуральное число N, а на выходе
//показывает его цифры через запятую.
int n = 8;
int i = 1;
int ver = n;

while (ver != 0)
{
    ver = ver / 10;
    i *= 10;
}
while (i > 1)
{
    i=i/10;
    ver = n / i;
    if (i > 1)
    {
        Console.Write(ver + " ,");
        n = n % i;
    }
    else
    {
        Console.Write(ver);
    }
}