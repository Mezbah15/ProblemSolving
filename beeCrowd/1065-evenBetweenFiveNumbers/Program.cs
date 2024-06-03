/* 1065
----------
Make a program that reads five integer values. Count how many of these values ​​are even and  print this information like the following example.

Input
The input will be 5 integer values.

Output
Print a message like the following example with all letters in lowercase, indicating how many even numbers were typed.

Input Sample	Output Sample
7
-5
6
-4
12

3 valores pares
*/
int count = 0;
double[] numbers = new double[5];
for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = double.Parse(Console.ReadLine());

    if (numbers[i] % 2 == 0)
    {
        count++;
    }
}
Console.WriteLine(count + " valores pares");