/* 1131
----------
 Write a program that read the number of goals scored by Inter and the number of goals scored by Gremio in a GRENAL. Write the message "Novo grenal (1-sim 2-nao)" and request a response. If the answer is 1, two new numbers must be read (another input case) asking the number of goals scored by the teams in a new departure, otherwise the program must be finished, printing:

- How many GRENAIS were part of the statistics.
- The number of victories of Inter.
- The number of victories of Gremio.
- The number of Draws.
- A message indicating the team that won the largest number of GRENAIS (or the message: "Não houve vencedor" if both team won the same quantity of GRENAIS).

Input
The input contains two integer values​​, corresponding to the goals scored by both teams. Then there is an integer (1 or 2), corresponding to the repetition of the algorithm.

Output
After each reading of the goals it must be printed the message "Novo grenal (1-sim 2-nao)". When the program is finished, the program must print the statistics as the example below.

Input Sample	Output Sample
3 2
1
2 3
1
3 1
2

Novo grenal (1-sim 2-nao)
Novo grenal (1-sim 2-nao)
Novo grenal (1-sim 2-nao)
3 grenais
Inter:2
Gremio:1
Empates:0
Inter venceu mais */
int totalGame = 1;
int interWin = 0;
int gremioWin = 0;
int draw = 0;

string[] input = Console.ReadLine().Split();
int inter = int.Parse(input[0]);
int gremio = int.Parse(input[1]);

if (inter > gremio)
{
    interWin++;
}
else if (inter < gremio)
{
    gremioWin++;
}
else if (inter == gremio)
{
    draw++;
}

while (true)
{
    Console.WriteLine("Novo grenal (1-sim 2-nao)");

    int option = int.Parse(Console.ReadLine());
    if (option == 1)
    {
        totalGame++;
        input = Console.ReadLine().Split();
        inter = int.Parse(input[0]);
        gremio = int.Parse(input[1]);

        if (inter > gremio)
        {
            interWin++;
        }
        else if (inter < gremio)
        {
            gremioWin++;
        }
        else if (inter == gremio)
        {
            draw++;
        }
    }
    else
    {
        break;
    }
}

Console.WriteLine(totalGame + " grenais");
Console.WriteLine("Inter:" + interWin);
Console.WriteLine("Gremio:" + gremioWin);
Console.WriteLine("Empates:" + draw);
if (interWin > gremioWin)
{
    Console.WriteLine("Inter venceu mais");
}
else if (interWin < gremioWin)
{
    Console.WriteLine("Gremio venceu mais");
}
else
{
    Console.WriteLine("Não houve vencedor");
}



