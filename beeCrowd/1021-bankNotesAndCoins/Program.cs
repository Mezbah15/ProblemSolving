/* 1021
---------------
Read a value of floating point with two decimal places. This represents a monetary value. After this, calculate the smallest possible number of notes and coins on which the value can be decomposed. The considered notes are of 100, 50, 20, 10, 5, 2. The possible coins are of 1, 0.50, 0.25, 0.10, 0.05 and 0.01. Print the message “NOTAS:” followed by the list of notes and the message “MOEDAS:” followed by the list of coins.

Input
The input file contains a value of floating point N (0 ≤ N ≤ 1000000.00).

Output
Print the minimum quantity of banknotes and coins necessary to change the initial value, as the given example. */


var amount = Console.ReadLine();
var indexPart = amount.IndexOf(".");

var integerPart = amount.Substring(0, indexPart);
var integerV = int.Parse(integerPart);
Console.WriteLine("Integer : " + integerV);

var decimalPart = amount.Substring(indexPart);
var decimalV = int.Parse(decimalPart);
int doublePortion = (int)decimalV;
Console.WriteLine("Decimal : " + decimalV);


var hundredNotes = integerV / 100;
var hundredNotesRest = integerV % 100;

var fiftyNotes = hundredNotesRest / 50;
var fiftyNotesRest = hundredNotesRest % 50;

var twentyNotes = fiftyNotesRest / 20;
var twentyNotesRest = fiftyNotesRest % 20;

var tenthNotes = twentyNotesRest / 10;
var tenthNotesRest = twentyNotesRest % 10;

var fifthNotes = tenthNotesRest / 5;
var fifthNotesRest = tenthNotesRest % 5;

var twoNotes = fifthNotesRest / 2;
var twoNotesRest = fifthNotesRest % 2;
// Coins
var hundredCoin = twoNotesRest;
//var hundredCoinRest = twoNotesRest % 1;

var fiftyCoin = doublePortion / 50;
var fiftyCoinRest = doublePortion % 50;

var twentyFiveCoin = fiftyCoinRest / 0.25;
var twentyFiveCoinRest = fiftyCoinRest % 0.25;

var tenthCoin = twentyFiveCoinRest / 0.10;
var tenthCoinRest = twentyFiveCoinRest % 0.10;

var fifthCoin = tenthCoinRest / 0.05;
var fifthCoinRest = tenthCoinRest % 0.05;

var oneCoin = fifthCoinRest;


Console.WriteLine(amount);
Console.WriteLine("NOTAS");
Console.WriteLine($"{hundredNotes} notas(s) de R$ 100.00");
Console.WriteLine($"{fiftyNotes} notas(s) de R$ 50.00");
Console.WriteLine($"{twentyNotes} notas(s) de R$ 20.00");
Console.WriteLine($"{tenthNotes} notas(s) de R$ 10.00");
Console.WriteLine($"{fifthNotes} notas(s) de R$ 5.00");
Console.WriteLine($"{twoNotes} notas(s) de R$ 2.00");

Console.WriteLine("MOEDAS");
Console.WriteLine($"{hundredCoin} moeda(s) de R$ 1.00");
Console.WriteLine($"{fiftyCoin} moeda(s) de R$ 0.50");
Console.WriteLine($"{twentyFiveCoin} moeda(s) de R$ 0.25");
Console.WriteLine($"{tenthCoin} moeda(s) de R$ 0.20");
Console.WriteLine($"{fifthCoin} moeda(s) de R$ 0.05");
Console.WriteLine($"{oneCoin} moeda(s) de R$ 0.01");
