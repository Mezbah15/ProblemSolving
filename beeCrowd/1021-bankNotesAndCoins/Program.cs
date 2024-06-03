/* 1021
---------------
Read a value of floating point with two decimal places. This represents a monetary value. After this, calculate the smallest possible number of notes and coins on which the value can be decomposed. The considered notes are of 100, 50, 20, 10, 5, 2. The possible coins are of 1, 0.50, 0.25, 0.10, 0.05 and 0.01. Print the message “NOTAS:” followed by the list of notes and the message “MOEDAS:” followed by the list of coins.

Input
The input file contains a value of floating point N (0 ≤ N ≤ 1000000.00).

Output
Print the minimum quantity of banknotes and coins necessary to change the initial value, as the given example. */

/**
var amount = Console.ReadLine();
var indexPart = amount.IndexOf(".");

var integerPart = amount.Substring(0, indexPart);
var integerV = int.Parse(integerPart);
Console.WriteLine("Integer : " + integerV);

var decimalPart = amount.Substring(indexPart);
var doublePortion = (int)(double.decimalPart * 100);
Console.WriteLine("Decimal : " + doublePortion);
**/
double amount = double.Parse(Console.ReadLine());

int integerPart = (int)amount;
int decimalPart = (int)((amount - integerPart) * 100);

int hundredNotes = integerPart / 100;
int hundredNotesRest = integerPart % 100;

int fiftyNotes = hundredNotesRest / 50;
int fiftyNotesRest = hundredNotesRest % 50;

int twentyNotes = fiftyNotesRest / 20;
int twentyNotesRest = fiftyNotesRest % 20;

int tenthNotes = twentyNotesRest / 10;
int tenthNotesRest = twentyNotesRest % 10;

int fifthNotes = tenthNotesRest / 5;
int fifthNotesRest = tenthNotesRest % 5;

int twoNotes = fifthNotesRest / 2;
int twoNotesRest = fifthNotesRest % 2;
// Coins
int hundredCoin = twoNotesRest;
//var hundredCoinRest = twoNotesRest % 1;

var fiftyCoin = decimalPart / 50;
var fiftyCoinRest = decimalPart % 50;

var twentyFiveCoin = fiftyCoinRest / 25;
var twentyFiveCoinRest = fiftyCoinRest % 25;

var tenthCoin = twentyFiveCoinRest / 10;
var tenthCoinRest = twentyFiveCoinRest % 10;

var fifthCoin = tenthCoinRest / 5;
var fifthCoinRest = tenthCoinRest % 5;

var oneCoin = fifthCoinRest;


Console.WriteLine(amount);
Console.WriteLine("NOTAS");
Console.WriteLine($"{hundredNotes} nota(s) de R$ 100.00");
Console.WriteLine($"{fiftyNotes} nota(s) de R$ 50.00");
Console.WriteLine($"{twentyNotes} nota(s) de R$ 20.00");
Console.WriteLine($"{tenthNotes} nota(s) de R$ 10.00");
Console.WriteLine($"{fifthNotes} nota(s) de R$ 5.00");
Console.WriteLine($"{twoNotes} nota(s) de R$ 2.00");

Console.WriteLine("MOEDAS");
Console.WriteLine($"{hundredCoin} moeda(s) de R$ 1.00");
Console.WriteLine($"{fiftyCoin} moeda(s) de R$ 0.50");
Console.WriteLine($"{twentyFiveCoin} moeda(s) de R$ 0.25");
Console.WriteLine($"{tenthCoin} moeda(s) de R$ 0.10");
Console.WriteLine($"{fifthCoin} moeda(s) de R$ 0.05");
Console.WriteLine($"{oneCoin} moeda(s) de R$ 0.01");
