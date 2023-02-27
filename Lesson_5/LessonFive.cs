using AssistantClass;
namespace Lesson;
public class LessonFive
{
    private Assistant assistant = new Assistant();
    public void EnterTaskNumber()
    {
        int taskNumber = assistant.TakeConsoleInt("Enter the task number or press 0 to end the job");
        switch (taskNumber)
        {
            case 34:
                Task_34();
                EnterTaskNumber();
                break;
            case 36:
                Task_36();
                EnterTaskNumber();
                break;
            case 38:
                Task_38();
                EnterTaskNumber();
                break;
            case 0:
                Console.Write($"Exit\n");
                break;
            default:
                Console.Write($"Wrong task number \n");
                EnterTaskNumber();
                break;
        }
    }
    private void Task_34()
    {
        Console.WriteLine("The program creates an array of three-digit numbers, and shows the number of positive numbers in the array");
        int[] mas = assistant.CreateIntArray();
        assistant.FillArray(ref mas, 100, 1000);
        int countEvent = 0;
        for (int i = 0; i < mas.Length; i++)
        {
            if(mas[i] % 2 == 0) 
                countEvent++;
        }
        assistant.PrintArray(mas);
        Console.Write($"Count Even {countEvent}\n");
    }

    private void Task_36()
    {
        Console.WriteLine("The program creates an array of numbers, and shows the sum of the elements in odd positions");
        int[] mas = assistant.CreateIntArray();
        assistant.FillArray(ref mas, -40, 100);
        int sumPositive = 0;
        for (int i = 0; i < mas.Length; i++)
        {
            if(i % 2 != 0) 
                sumPositive += mas[i];
        }
        assistant.PrintArray(mas);
        Console.Write($"Sum Positive {sumPositive}\n");
    }

    private void Task_38()
    {
        Console.WriteLine("The program creates an array of numbers, and shows the sum of the elements in odd positions");
        int[] mas = assistant.CreateIntArray();
        assistant.FillArray(ref mas, -40, 100);
        int min = Int32.MaxValue; //mas.Min();
        int max = Int32.MinValue; //mas.Max();
        FindMinMaxElement(mas, ref min, ref max);
        int difference = max - min;
        assistant.PrintArray(mas);
        Console.Write($"Difference between min = {min} and max = {max} is = {difference}\n");
        Console.Write($"(using built-in methods) Difference between min = {mas.Min()} and max = {mas.Max()} is = {mas.Max() - mas.Min()}\n");
    }
    private void FindMinMaxElement(int [] array, ref int min, ref int max)
    {
        foreach (var item in array)
        {
            if (item > max){
                max = item;
            }
            else if(item < min){
                min = item;
            }
        } 
    }
}