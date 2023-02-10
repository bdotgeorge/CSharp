void FindMinMax(int[] items)
{
    if (items[0] > items[1])
    {
        Console.Write($"max = {items[0]}\nmin = {items[1]}\n");
    }
    else
    {
        Console.Write($"max = {items[1]}\nmin = {items[0]}\n");
    }
}

void TaskTwo()
{
    int[] numb = new int[2];
    int i = 0;
    Console.WriteLine("A program that takes two numbers as input and outputs which number is greater and which is smaller.");
    while (i < numb.Length)
    {
        Console.WriteLine("Enter an integer");
        if (int.TryParse(Console.ReadLine()!, out numb[i]))
            i++;
        else
            Console.WriteLine("Wrong number!!!");
    }
    FindMinMax(numb);
}

void TaskFour()
{
    Console.WriteLine("A program that takes three numbers as input and outputs the maximum of these numbers");
    int max_num = int.MinValue;
    int temp = int.MinValue;
    int countNum = 0;
    while (countNum < 3)
    {
        Console.WriteLine("Enter an integer");
        if (int.TryParse(Console.ReadLine()!, out temp))
        {
            if (max_num < temp)
            {
                max_num = temp;
            }
            countNum++;
        }
        else
            Console.WriteLine("Wrong number!!!");
    }
    Console.WriteLine($"Max number = {max_num}");
}

void TaskSix()
{
    Console.WriteLine("A program that takes a number as input and outputs whether the number is even (whether it is divisible by two without a remainder)");
    Console.WriteLine("Enter an integer");
    int even = 0;
    if (int.TryParse(Console.ReadLine()!, out even))
    {
        if (even % 2 == 0)
            Console.WriteLine($"{even}->Yes");
        else
            Console.WriteLine($"{even}->No");
    }
}

void TaskEight(){
    Console.WriteLine("A program that takes a number (N) as input, and displays all even numbers from 1 to N as output");
    Console.WriteLine("Enter an integer");
    int N = 0;
    if (int.TryParse(Console.ReadLine()!, out N)){
        for (int i = 1; i <= N; i++)
        {
            if(i % 2 == 0)
                Console.WriteLine($"{i}");
        }
    }
}

TaskTwo();
TaskFour();
TaskSix();
TaskEight();




/*int[] numb = new int[3];
List<int> array = new List<int>();
int i = 0;
while(i < numb.Length){
    int a;
    int.TryParse(Console.ReadLine()!, out a);
    numb[i] = a;
    array.Add(a);
    Console.Write($"num = {numb[i]}\n");
    Console.Write($"array = {array[i]}\n");
    Console.WriteLine(array.Count);
    i++;
}
out == & == link
//numb.Append(4);*/