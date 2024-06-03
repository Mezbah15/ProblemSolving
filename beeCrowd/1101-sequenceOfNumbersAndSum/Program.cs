/* 1101
----------
Read an undetermined number of pairs values M and N (stop when any of these values is less or equal to zero). For each pair, print the sequence from the smallest to the biggest (including both) and the sum of consecutive integers between them (including both).

Input
The input file contains pairs of integer values M and N. The last line of the file contains a number zero or negative, or both.

Output
For each pair of numbers, print the sequence from the smallest to the biggest and the sum of these values, as shown below.

Input Sample	Output Sample
5 2
6 3
5 0

2 3 4 5 Sum=14
3 4 5 6 Sum=18 */

int M, N;
while (true)
{
    string[] numbers = Console.ReadLine().Split(); // 5 2
    M = int.Parse(numbers[0]); //5
    N = int.Parse(numbers[1]); //2
    if (M < 1 || N < 1)
    {
        break;
    }

    if (M > N)
    {
        int temp = M;
        M = N;
        N = temp;
    }

    int sum = 0;

    for (int i = M; i <= N; i++)
    {
        Console.Write(i + (" "));
        sum += i;       
    }
    Console.WriteLine("Sum=" + sum);
}
