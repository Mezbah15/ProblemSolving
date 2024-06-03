/* 1094
-----------
Maria has just started as graduate student in a medical school and she's needing your help to organize a laboratory experiment which she is responsible about. She wants to know, at the end of the year, how many animals were used in this laboratory and the percentage of each type of animal is used at all.

This laboratory uses in particular three types of animals: frogs, rats and rabbits. To obtain this information, it knows exactly the number of experiments that were performed, the type and quantity of each animal is used in each experiment.

Input
The first line of input contains an integer N indicating the number of test cases that follows. Each test case contains an integer Amount (1 ≤ Amount ≤ 15) which represents the amount of animal used and a character Type ('C', 'R' or 'S'), indicating the type of animal:
- C: Coelho (rabbit in portuguese)
- R: Rato (rat  in portuguese)
- S: Sapo (frog in portuguese)

Output
Print the total of animals used, the total of each type of animal and the percentual of each one in relation of the total of animals used. The percentual must be printed with 2 digits after the decimal point.

Input Sample	Output Sample
10
10 C
6 R
15 S
5 C
14 R
9 C
6 R
8 S
5 C
14 R

Total: 92 cobaias
Total de coelhos: 29
Total de ratos: 40
Total de sapos: 23
Percentual de coelhos: 31.52 %
Percentual de ratos: 43.48 %
Percentual de sapos: 25.00 % */

var N = int.Parse(Console.ReadLine());
int cRabbit = 0, rRat = 0, sFrog = 0, total = 0;
double totalRabbit = 0.0, totalRat = 0.0, totalFrog = 0.0;
double percentageRabbit = 0.0, percentageRat = 0.0, percentageFrog = 0.0;

for (int i = 0; i < N; i++)
{
    var animal = Console.ReadLine().Split();
    int num = int.Parse(animal[0]);
    char name = char.Parse(animal[1]);

    if (name == 'C')
    {
       // var num1 = int.Parse(Console.ReadLine());
        cRabbit += num;
    }
    else if (name == 'R')
    {
        //var num2 = int.Parse(Console.ReadLine());
        rRat += num;
    }
    else if (name == 'S')
    {
       // var num3 = int.Parse(Console.ReadLine());
        sFrog += num;
    }

        total = cRabbit + rRat + sFrog;
        totalRabbit = cRabbit;
        totalRat = rRat;
        totalFrog = sFrog;
        percentageRabbit = (totalRabbit / total) * 100;
        percentageRat = (totalRat / total) * 100;
        percentageFrog = (totalFrog / total) * 100;
}
Console.WriteLine($"Total: {total} cobaias");
Console.WriteLine($"Total de coelhos: {totalRabbit}");
Console.WriteLine($"Total de ratos: {totalRat}");
Console.WriteLine($"Total de sapos: {totalFrog}");
Console.WriteLine($"Percentual de coelhos: {percentageRabbit.ToString("F2")} %");
Console.WriteLine($"Percentual de ratos: {percentageRat.ToString("F2")} %");
Console.WriteLine($"Percentual de sapos: {percentageFrog.ToString("F2")} %");