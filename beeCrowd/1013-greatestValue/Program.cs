/* 1013
------------
Make a program that reads 3 integer values and present the greatest one followed by the message "eh o maior". Use the following formula:

MaiorAB = (a+b+Abs(a-b))/2
Input
The input file contains 3 integer values.

Output
Print the greatest of these three values followed by a space and the message “eh o maior”. */


string[]? input = Console.ReadLine().Split();

int firstValue = int.Parse(input[0]);
int secondValue = int.Parse(input[1]);
int thirdValue = int.Parse(input[2]);


var maiorAb = (firstValue + secondValue + Math.Abs(firstValue - secondValue)) / 2;
int greatest = (maiorAb + thirdValue + Math.Abs(maiorAb - thirdValue)) / 2;


//int greatestValue = Math.Max(Math.Max(firstValue, secondValue), thirdValue);
/**
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
*/
Console.WriteLine(greatest + " eh o maior");