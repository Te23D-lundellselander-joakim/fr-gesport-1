int Poäng = 0;
string val;

Console.WriteLine("Välkommen till min frågesport. Du kommer få 3 frågor att svara på. Lycka till");
Console.ReadLine();

Console.WriteLine("Fråga  1, vad h eter jag i efternamn ?");
Console.writeline
val = Console.ReadLine();
if (val.ToLower() == "a")
{
    Poäng++;
    Console.WriteLine("RÄTT SVAR!");
}
else
{
    Console.WriteLine("FEL SVAR!");
}


Console.WriteLine("Fråga 2,");
val = Console.ReadLine();
if (val.ToLower() == "")
{
    Poäng++;
    Console.WriteLine("RÄTT SVAR!");
}
else
{
    Console.WriteLine("FEL SVAR!");
}

Console.WriteLine("Fråga  3,");
val = Console.ReadLine();
if (val.ToLower() == "")
{
    Poäng++;
    Console.WriteLine("RÄTT SVAR!");
}
else
{
    Console.WriteLine("FEL SVAR!");
}

Console.WriteLine(Poäng);
Console.ReadLine();