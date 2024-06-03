/* 1072
------------
Read an integer N. This N will be the number of integer numbers X that will be read.

Print how many these numbers X are in the interval [10,20] and how many values are out of this interval.

Input
The first line of input is an integer N (N < 10000), that indicates the total number of test cases.
Each case is an integer number X (-107 < X < 107).

Output
For each test case, print how many numbers are in and how many values are out of the interval.

Input Sample	Output Sample
4
14
123
10
-25

2 in
2 out */

int testCaseN = int.Parse(Console.ReadLine()); //4
int intervalIn = 0;
int intervalOut = 0;
for (int i = 0; i < testCaseN; i++)
{
    int input = int.Parse(Console.ReadLine());
    if (input >= 10 && input <= 20)
    {
        intervalIn++;
    }
    else intervalOut++;
} 
Console.WriteLine($"{intervalIn} in");
Console.WriteLine($"{intervalOut} out");