﻿/* 1074
Read an integer value N. After, read these N values and print a message for each value saying if this value is odd, even, positive or negative. In case of zero (0), although the correct description would be "EVEN NULL", because by definition zero is even, your program must print only "NULL", without quotes.

Input
The first line of input is an integer N (N < 10000), that indicates the total number of test cases. Each case is a integer number X (-107 < X <107)..

Output
For each test case, print a corresponding message, according to the below example. All messages must be printed in uppercase letters and always will have one space between two words in the same line.

Input Sample	Output Sample
4
-5
0
3
-4

ODD NEGATIVE
NULL
ODD POSITIVE
EVEN NEGATIVE
*/
int testCaseN = int.Parse(Console.ReadLine());
string[] result = new string[testCaseN];

for (int i = 0; i < testCaseN; i++)
{
    int input = int.Parse(Console.ReadLine());
    if (input % 2 == 0 && input > 0)
    {
        result[i] = "EVEN POSITIVE";
    }
    else if (input % 2 == 0 && input < 0)
    {
        result[i] = "EVEN NEGATIVE";
    }
    else if (input % 2 != 0 && input > 0)
    {
        result[i] = "ODD POSITIVE";
    }
    else if (input % 2 != 0 && input < 0)
    {
        result[i] = "ODD NEGATIVE";
    }
    else if (input == 0)
    {
        result[i] = "NULL";
    }
}
for (int i = 0; i < testCaseN; i++)
{
    Console.WriteLine(result[i]);
}

