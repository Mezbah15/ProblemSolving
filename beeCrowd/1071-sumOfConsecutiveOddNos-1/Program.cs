/* 1071
-----------
Read two integer values X and Y. Print the sum of all odd values between them.

Input
The input file contain two integer values.

Output
The program must print an integer number. This number is the sum off all odd values between both input values that must fit in an integer number.

Sample Input	Sample Output
6
-5

5 */
/*
 * 5
 */
int X = int.Parse(Console.ReadLine());
int Y = int.Parse(Console.ReadLine());
int sum = 0;

int Y1 = Math.Max(X, Y);
int X1 = Math.Min(X, Y);

for (int i = X1+1; i < Y1; i += 1)
{
    if (i % 2 != 0)
    {
        sum += i; //-3-1+0+1+3+5

    }
   
}
Console.WriteLine(sum); 
