Console.Write("Enter a year: ");
int year = int.Parse(Console.ReadLine());

Console.WriteLine("Enter month(Press 1 for Jan, 2 for Feb, 12 for Dec......): ");
int month = int.Parse(Console.ReadLine());

Console.WriteLine("Enter Day of week(Press 1 for Mon, 2 for Tue, 7 for Sun......): ");
int day = int.Parse(Console.ReadLine());

int DaysInMonth = DateTime.DaysInMonth(year, month);



Console.WriteLine("S\tM\tT\tW\tT\tF\tS");

for (int i = 0; i < day; i++)
{
    if (day == 7)
    {
        continue;
    }
    else
    {
        Console.Write("\t");
    }

}

for (int i = 1; i <= DaysInMonth; i++)
{
    Console.Write(i + "\t");
    if ((day + i) % 7 == 0)
    {
        Console.WriteLine();
    }
}

