/* 1018	
 * ----------
 * In this problem you have to read an integer value and calculate the smallest possible number of banknotes in which the value may be decomposed. The possible banknotes are 100, 50, 20, 10, 5, 2 and 1. Print the read value and the list of banknotes.

Input
The input file contains an integer value N (0 < N < 1000000).

Output
Print the read number and the minimum quantity of each necessary banknotes in Portuguese language, as the given example. Do not forget to print the end of line after each line, otherwise you will receive “Presentation Error”. */

var amount = Convert.ToInt64(Console.ReadLine());

var hundredNotes = amount / 100;
var hundredRest = amount % 100;

var fiftyNotes = hundredRest / 50;
var fiftyRest = hundredRest % 50;

var twentyNotes = fiftyRest / 20;
var twentyRest = fiftyRest % 20;

var tenthNotes = twentyRest / 10;
var tenthRest = twentyRest % 10;

var fifthNotes = tenthRest / 5;
var fifthRest = tenthRest % 5;

var twoNotes = fifthRest / 2;
var twoRest = fifthRest % 2;

var oneNotes = twoRest;



Console.WriteLine(amount);
Console.WriteLine($"{hundredNotes} nota(s) de R$ 100,00");
Console.WriteLine($"{fiftyNotes} nota(s) de R$ 50,00");
Console.WriteLine($"{twentyNotes} nota(s) de R$ 20,00");
Console.WriteLine($"{tenthNotes} nota(s) de R$ 10,00");
Console.WriteLine($"{fifthNotes} nota(s) de R$ 5,00");
Console.WriteLine($"{twoNotes} nota(s) de R$ 2,00");
Console.WriteLine($"{oneNotes} nota(s) de R$ 1,00");