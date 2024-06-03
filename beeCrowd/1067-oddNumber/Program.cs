/* 1067
---------------
Read an integer value X (1 <= X <= 1000).  Then print the odd numbers from 1 to X, each one in a line, including X if is the case.

Input
The input will be an integer value.

Output
Print all odd values between 1 and X, including X if is the case.

Input Sample	Output Sample
8

1
3
5
7
*/
int X = int.Parse(Console.ReadLine());
for (int i = 0; i <= X; i++)
{
    if (i % 2 != 0)
    {
        Console.WriteLine(i);
    }
}