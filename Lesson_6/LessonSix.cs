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
        var tuple = (1, 3);
        Console.Write($"Sum Positive {tuple}\n");
    }

        private (double, double) CrossPoint(int [] array, ref int min, ref int max)
    {   
        double x = 0;
        double y = 0;
        double y2 = 0;

        if(array.Length > 4)
        {
            for(int i = 0; i < array.Length; i +=4){
               y = array[i + 1] * x + array[i];
                array[i + 1];
                array[i + 2];
                array[i + 3];
            }
        }

        return (x, y);
    }
}