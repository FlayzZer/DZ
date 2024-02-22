//Напишите программу, которая принимает
//на вход целое число из отрезка [10, 99] и показывает
//наибольшую цифру числа.
int num=72;
int first=num/10;
int second=num%10;
if(first>second)
{
    Console.Write(first);
}
else
{
    Console.Write(second);
}