void TaskTen()
{
    Console.Write("The program takes a three-digit number as input and displays the second digit of this number as output\nEnter an integer from 100 to 999\n");
    int number = 0;
    Console.WriteLine((int.TryParse(Console.ReadLine()!, out number) && number > 99 && number < 1000) ? $"{number} -> {(number / 10) % 10}" : "Wrong number!!!");
}
void TaskThirteen()
{
    Console.Write("The program which prints the third digit of the given number or reports that there is no third digit\n");
    string s = Console.ReadLine()!;
    int number = 0;
    Console.WriteLine((int.TryParse(s, out number) && Math.Abs(number) > 99) ? $"{Math.Abs(number).ToString()[2]}" : "No third digit");
}
void TaskFifteen()
{
    Console.Write("The program which takes as input a digit indicating the day of the week and checks if this day is a weekend\nEnter an integer from 1 to 7\n");
    int number = 0;
    Console.WriteLine((int.TryParse(Console.ReadLine()!, out number) && number > 5 && number < 8) ? $"{number} -> Yes" : "No");
}

TaskTen();
TaskThirteen();
TaskFifteen();