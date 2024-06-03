/* 1132
---------
Write a program that reads two integer numbers X and Y and calculate the sum of all number not divisible by 13 between them, including both.
Input
The input file contains 2 integer numbers X and Y without any order.
Output
Print the sum of all numbers between X and Y not divisible by 13, including them if it is the case.
Input Sample	Output Sample
100
200

13954
*/
int sum = 0;
int X = int.Parse(Console.ReadLine());
int Y = int.Parse(Console.ReadLine());

if (X > Y)
{
    int temp = X;
    X = Y;
    Y = temp;
}
for (int i = X; i <= Y; i++)
{
    if (i % 13 != 0)
    {
        sum += i;
    }
}
Console.WriteLine(sum);