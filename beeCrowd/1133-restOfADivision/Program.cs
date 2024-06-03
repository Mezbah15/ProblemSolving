/* 1133
----------
Write a program that reads two integer numbers X and Y. Print all numbers between X and Y which dividing it by 5 the rest is equal to 2 or equal to 3.
Input
The input file contains 2 any positive integers, not necessarily in ascending order.
Output
Print all numbers according to above description, always in ascending order.
Input Sample	Output Sample
10
18

12
13
17
*/

int X = int.Parse(Console.ReadLine());
int Y = int.Parse(Console.ReadLine());
if (X > Y)
{
    int temp = X;
    X = Y;
    Y = temp;
}
for (int i = X+1; i < Y; i++)
{
    if (i % 5  == 2  || i % 5 == 3)
    {
        Console.WriteLine(i);
    }
}