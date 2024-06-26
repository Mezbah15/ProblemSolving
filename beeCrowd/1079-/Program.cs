﻿using System.Linq; // for sum();
/* 1079
-------
Read an integer N, which represents the number of following test cases. Each test case consists of three floating-point numbers, each one with one digit after the decimal point. Print the weighted average for each of these sets of three numbers, considering that the first number has weight 2, the second number has weight 3 and the third number has weight 5.

Input
The input file contains an integer number N in the first line. Each N following line is a test case with three float-point numbers, each one with one digit after the decimal point.

Output
For each test case, print the weighted average according with below example.

Input Sample	Output Sample
3
6.5 4.3 6.2
5.1 4.2 8.1
8.0 9.0 10.0

5.7
6.3
9.3
*/

int N = int.Parse(Console.ReadLine());
var average = new double[N];
double[]? weightedInput = new double[3];
double[]? doubleInput = new double[3];
double[] weight = { 2, 3, 5 };

for (int j = 0; j < N; j++)
{
    string[]? input = Console.ReadLine().Split();

    for (int i = 0; i < 3; i++)
    {
        doubleInput[i] = double.Parse(input[i]);
        weightedInput[i] = doubleInput[i] * weight[i];
    }

    average[j] = weightedInput.Sum() / weight.Sum();
}
for (int k = 0; k < average.Length; k++)
{
    Console.WriteLine(average[k].ToString("F1"));
}