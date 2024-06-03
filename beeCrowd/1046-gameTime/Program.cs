/*
 * 1046
------
Read the start time and end time of a game, in hours. Then calculate the duration of the game, knowing that the game can begin in a day and finish in another day, with a maximum duration of 24 hours. The message must be printed in portuguese “O JOGO DUROU X HORA(S)” that means “THE GAME LASTED X HOUR(S)”

Input
Two integer numbers representing the start and end time of a game.

Output
Print the duration of the game as in the sample output.

Input Sample	Output Sample
16 2

O JOGO DUROU 10 HORA(S)
*/
string? input = Console.ReadLine() ?? string.Empty;
string[]? time = input.Split();
int duration = 0;
int startTime = int.Parse(time[0]);
int endTime = int.Parse(time[1]);

if (startTime < endTime)
{
     duration = (endTime - startTime);
}
else if (startTime > endTime)
{
    duration = (24 - startTime + endTime);
}
else if (startTime == endTime)
{
    duration += 24;
}
Console.WriteLine($"O JOGO DUROU {duration} HORA(S)");
