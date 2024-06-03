/* A Prime Number is a number that is divisible only by 1 (one) and by itself. For example the number 7 is Prime, because it can be divided only by 1 and by 7.

Input
The input contains several test cases. The first contains the number of test cases N (1 ≤ N ≤ 100). Each one of the following N lines contains an integer X (1 < X ≤ 107), that can be or not a prime number.

Output
For each test case print the message “X eh primo” (X is prime) or “X nao eh primo” (X isn't prime) according with to above specification.

Input Sample	Output Sample
3
8
51
7

8 nao eh primo
51 nao eh primo
7 eh primo */

int testCaseN = int.Parse(Console.ReadLine());
for (int i = 0; i < testCaseN; i++)
{
    int input = int.Parse(Console.ReadLine());
    int count = 0;

    if (input < 2)
    {
        count++;
    }
    else if (input == 2)
    {
        count = 0;
    }
    for (int k = 2; k <= input-1; k++)
    {
        if (input % k == 0)
        {
            count++;
        }
    }
    if (count == 0)
    {
        Console.WriteLine(input + " eh primo");
    }
    else
    {
        Console.WriteLine(input + " nao eh primo");
    }
}