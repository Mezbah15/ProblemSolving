/* Read a value N. Calculate and write its corresponding factorial. Factorial of N = N * (N-1) * (N-2) * (N-3) * ... * 1.

Input
The input contains an integer value N (0 < N < 13).

Output
The output contains an integer value corresponding to the factorial of N.

Input Sample	Output Sample
4

24 */

int N = int.Parse(Console.ReadLine());
int fact = 1;
for (int i = 1; i <= N; i++)
{
    fact = fact * i;
}
Console.WriteLine(fact); 
