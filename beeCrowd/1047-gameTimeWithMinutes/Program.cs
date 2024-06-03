/*1047
----------
Read the start time and end time of a game, in hours and minutes (initial hour, initial minute, final hour, final minute). Then print the duration of the game, knowing that the game can begin in a day and finish in another day,

Obs.: With a maximum game time of 24 hours and the minimum game time of 1 minute.

Input
Four integer numbers representing the start and end time of the game.

Output
Print the duration of the game in hours and minutes, in this format: “O JOGO DUROU XXX HORA(S) E YYY MINUTO(S)” . Which means: the game lasted XXX hour(s) and YYY minutes.

Input Sample	Output Sample
7 8 9 10

O JOGO DUROU 2 HORA(S) E 2 MINUTO(S) */

string? inputTime = Console.ReadLine() ?? string.Empty;
string[]? time = inputTime.Split();
int startHour = int.Parse(time[0]);
int startMinute = int.Parse(time[1]);
int endHour = int.Parse(time[2]);
int endMinute = int.Parse(time[3]);
int hour = 0;
int minute = 0;

//7 8 9 10
if (startHour < endHour)
{
    hour = endHour - startHour;
}
else if (startHour > endHour)
{
    hour = 24 - startHour + endHour;
}
//else if (startHour == 0 && endHour == 0)
//{
//    hour = 0;
//}
else if (startHour == endHour)
{
    hour += 0;
}

if (startMinute < endMinute)
{
    minute = endMinute - startMinute;
}
else if (startMinute > endMinute)
{
    minute = 60 - startMinute + endMinute;
    hour -= 1;
}
else if (startMinute == endMinute)
{
    minute += 1;
}

Console.WriteLine($"O JOGO DUROU {hour} HORA(S) E {minute} MINUTO(S)");