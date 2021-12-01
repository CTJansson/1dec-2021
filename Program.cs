// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string[] lines = File.ReadAllLines("./input.txt");

int increament = 0;

for (int i = 1; i < lines.Length; i++)
{
    int.TryParse(lines[i-1], out int lineA);
    int.TryParse(lines[i], out int lineB);

    if (lineA < lineB) 
    {
        increament++;
    }
}

Console.ReadLine();