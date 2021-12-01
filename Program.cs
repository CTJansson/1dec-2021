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
    if (numbers[i-1] < numbers[i]) 
    {
        increamentPartA++;
    }

    if (i +2 < lines.Count)
    {
        int compareA = numbers[i - 1] + numbers[i] + numbers[i + 1];
        int compareB = numbers[i] + numbers[i + 1] + numbers[i + 2];

        if (compareA < compareB)
        {
            increamentPartB++;
        }
    }    
}

Console.WriteLine("Part A: " + increamentPartA.ToString());
Console.WriteLine("Part B: " + increamentPartB.ToString());
Console.ReadLine();