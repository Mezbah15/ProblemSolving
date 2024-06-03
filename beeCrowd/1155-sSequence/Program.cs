/*
Write an algorithm to calculate and write the value of S, S being given by:
S = 1 + 1/2 + 1/3 + … + 1/100

Input
There is no input in this problem.

Output
The output contains a value corresponding to the value of S.
The value should be printed with two digits after the decimal point. */

double S = 1.0;
for (int i = 2; i <= 100; i++)
{
  double iter =  1.0 / i;

    S += iter;
}

Console.WriteLine(S.ToString("0.00"));