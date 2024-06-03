﻿/* 1097
----------
Make a program that prints the sequence like the following exemple.

Input
This problem doesn't have input.

Output
Print the sequence like the example below.

Input Sample	Output Sample

I=1 J=7
I=1 J=6
I=1 J=5
I=3 J=9
I=3 J=8
I=3 J=7
........
I=9 J=15
I=9 J=14
I=9 J=13


*/
int i = 1;
int j = 7;
while (i <= 9)
{
    Console.WriteLine($"I={i} J={j}");
    j--; //

    if (j < i + 4) //
    {
        i += 2; // 
        j += 5; // 
    }

}