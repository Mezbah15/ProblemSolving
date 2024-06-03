/* 1070
---------------
Read an integer value X and print the 6 consecutive odd numbers from X, a value per line, including X if it is the case.

Input
The input will be a positive integer value.

Output
The output will be a sequence of six odd numbers.

Input Sample	Output Sample
8

9
11
13
15
17
19
*/
var X = int.Parse(Console.ReadLine());

if (X % 2 == 0)
{
    X++;
}

int count = 0;
while (count < 6)
{
    Console.WriteLine(X);
    X += 2;
    count++;
}
