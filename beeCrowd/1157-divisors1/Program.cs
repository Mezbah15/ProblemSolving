/* Read an integer N and compute all its divisors.
Input
The input file contains an integer value.

Output
Write all positive divisors of N, one value per line.

Input Sample	Output Sample
6

1
2
3
6 */

int inputN = int.Parse(Console.ReadLine());
for (int i = 1; i <= inputN; i++)
{
	if (inputN % i == 0)
	{
        Console.WriteLine(i);
    }
}