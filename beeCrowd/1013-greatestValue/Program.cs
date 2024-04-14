/* 1013
------------
Make a program that reads 3 integer values and present the greatest one followed by the message "eh o maior". Use the following formula:

Input
The input file contains 3 integer values.

Output
Print the greatest of these three values followed by a space and the message “eh o maior”. */


int firstValue = Convert.ToInt32(Console.ReadLine());
int secondValue = Convert.ToInt32(Console.ReadLine());
int thirdValue = Convert.ToInt32(Console.ReadLine());


//int greatestValue = Math.Max(Math.Max(firstValue, secondValue), thirdValue);

int greatestValue = firstValue;

if (secondValue > greatestValue)
{
    greatestValue = secondValue;
}
else if (thirdValue > greatestValue)
{
    greatestValue = thirdValue;
}
else
{
    Console.WriteLine("Enter Right Value");
}
Console.WriteLine("eh o maior = " + greatestValue);