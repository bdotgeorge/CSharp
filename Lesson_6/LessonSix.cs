using AssistantClass;
namespace Lesson;
public class LessonSix
{
    private Assistant assistant = new Assistant();
    public void EnterTaskNumber()
    {
        int taskNumber = assistant.TakeConsoleInt("Enter the task number or press 0 to end the job");
        switch (taskNumber)
        {
            case 41:
                Task_41();
                EnterTaskNumber();
                break;
            case 43:
                Task_43();
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
    private void Task_41()
    {
        Console.WriteLine("How many numbers greater than 0 the user entered");
        double[] mas = assistant.TakeArrayInConsole();
        int count = 0;
        foreach (double item in mas)
        {
            if(item > 0)
                count++;
        }
        Console.Write($"Count Positive {count}\n");
    }

    private void Task_43()
    {
        Console.WriteLine("The program finds the point of intersection of two lines");
        double[] mas = assistant.TakeArrayInConsole();
        var tuple = (CrossPoint(mas, 0, 1));
        Console.Write($"Sum Positive {tuple}\n");
    }

    private (double, double) CrossPoint(int [] array, ref int coefficient, ref int constanta)
    {   
        double x = 0;
        double y = 0;
        for(int i = 0; i < array.Lenght; i +=4)
        double k1 = 5, b1 = 2, k2 = 9, b2 = 4;
        x = (b1 - b2) / (k2 - k1);
        y = k2 * x + b2;
        return (x, y);
    }
}