/* 1004
 * ---------
 * Read two integer values. After this, calculate the product between them and store the result in a variable named PROD.
 * Print the result like the example below. Do not forget to print the end of line after the result, 
 * otherwise you will receive “Presentation Error”.

Input
The input file contains 2 integer numbers.

Output
Print the message "PROD" and PROD according to the following example, with a blank space before and after the equal signal. */

Console.WriteLine("Enter First value: ");
int firstInt = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Enter Second value: ");
int SecondInt = Convert.ToInt16(Console.ReadLine());

int PROD = (firstInt * SecondInt);

Console.WriteLine("PROD = " + PROD);