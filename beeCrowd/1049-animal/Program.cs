/* 1049
------
In this problem, your job is to read three Portuguese words. These words define an animal according to the table below, from left to right. After, print the chosen animal defined by these three words.

Input
The input contains 3 words, one by line, that will be used to identify the animal, according to the above table, with all letters in lowercase.

Output
Print the animal name according to the given input.

Input Samples	Output Samples
vertebrado
mamifero
onivoro

homem
*/
var input1 = Console.ReadLine();
var input2 = Console.ReadLine();
var input3 = Console.ReadLine();   

if (input1 == "vertebrado")
{
    if (input2 == "ave")
    {
        if (input3 == "carnivoro")
        {
            Console.WriteLine("aguia");
        }
        else if (input3 == "onivoro")
        {
            Console.WriteLine("pomba");
        }
    }
    else if (input2 == "mamifero")
    {
        if (input3 == "onivoro")
        {
            Console.WriteLine("homem");
        }
        else if (input3 == "herbivoro")
        {
            Console.WriteLine("vaca");
        }
    }
}
else if (input1 == "invertebrado")
{
    if (input2 == "inseto")
    {
        if (input3 == "hematofago")
        {
            Console.WriteLine("pulga");
        }
        else if (input3 == "herbivoro")
        {
            Console.WriteLine("lagarta");
        }
    }
    else if (input2 == "anelideo")
    {
        if (input3 == "hematofago")
        {
            Console.WriteLine("sanguessuga");
        }
        else if (input3 == "onivoro")
        {
            Console.WriteLine("minhoca");
        }
    }
}
else
{
    Console.WriteLine("Enter Correct Words!");
}