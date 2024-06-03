/* 1099
---------
Read an integer N that is the number of test cases. Each test case is a line containing two integer numbers X and Y. Print the sum of all odd values between them, not including X and Y.

Input
The first line of input is an integer N that is the number of test cases that follow. Each test case is a line containing two integer X and Y.

Output
Print the sum of all odd numbers between X and Y.

Input Sample	Output Sample
7

4 5

13 10

6 4

3 3

3 5

3 4

3 8

0

11

5

0

0

0

12 */

var N = int.Parse(Console.ReadLine());
int[] X = new int[N];
int[] Y = new int[N];
int[] sum = new int[N];

for (int i = 0; i < N; i++)
{
    var input = Console.ReadLine().Split();
    X[i] = int.Parse(input[0]);
    Y[i] = int.Parse(input[1]);
    if (X[i] > Y[i])
    {
        int temp = X[i];
        X[i] = Y[i];
        Y[i] = temp;
    }
    for (int j = X[i]+ 1; j < Y[i]; j++)
    {
        if(j % 2 != 0)
        {
            sum[i] += j;
        }
    }
}
for (int i = 0; i < N; i++)
{
    Console.WriteLine(sum[i]);
}