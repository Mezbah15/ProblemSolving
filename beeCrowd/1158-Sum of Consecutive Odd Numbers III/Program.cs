/* Read an integer N that is the number of test cases that follows. Each test case contains two integers X and Y. Print one output line for each test case that is the sum of Y odd numbers from X including it if is the case. For example:
for the input 4 5, the output must be 45, that is: 5 + 7 + 9 + 11 + 13
for the input 7 4, the output must be 40, that is: 7 + 9 + 11 + 13

Input
The first line of the input is an integer N that is the number of test cases that follow. Each test case is a line containing two integer X and Y.

Output
Print the sum of all consecutive odd numbers from X.

Input Sample	Output Sample
2
4 3
11 2

21
24 */
int testCaseN = int.Parse(Console.ReadLine());
for (int i = 1; i <= testCaseN; i++)
{
    string[] input = Console.ReadLine().Split();

    int X = int.Parse(input[0]);
    int Y = int.Parse(input[1]);
    if (X % 2 == 0)
    {
        X++;
    }
    //3 <= 2
    int sum = 0;
    int count = 1;
    while (count <= Y)
    {
        sum += X;
        X += 2;
        count++;
    }
    Console.WriteLine(sum);
}