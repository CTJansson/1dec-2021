// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

List<string> lines = File.ReadAllLines("./input.txt").ToList();
List<int> numbers = new List<int>();

foreach (var line in lines)
{
    numbers.Add(int.Parse(line));
}

int increamentPartA = 0;
int increamentPartB = 0;

for (int i = 1; i < lines.Count; i++)
{
    int.TryParse(lines[i-1], out int lineA);
    int.TryParse(lines[i], out int lineB);

    if (lineA < lineB) 
    {
        increamentPartA++;
    }

    
}

Console.WriteLine(increamentPartA.ToString());
Console.ReadLine();