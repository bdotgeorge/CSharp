using AssistantClass;
namespace Lesson;
public class LessonAll
{
    private Assistant assistant = new Assistant();
    public void EnterTaskNumber()
    {
        int taskNumber = assistant.TakeConsoleInt("Enter the task number or press 0 to end the job");
        switch (taskNumber)
        {
            case 47:
                Task47();
                EnterTaskNumber();
                break;
            case 50:
                Task50();
                EnterTaskNumber();
                break;
            case 52:
                Task52();
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
    private void Task47()
    {
        Console.WriteLine("two-dimensional array of size M × N, filled with random real numbers");
        int M = 1, N = 1;
        double[] value = assistant.TakeArrayInConsole("Enter size array Row and Colum");
        if (value.Length >= 2)
        {
            M = (int)value[0];
            N = (int)value[1];
            double[,] array = assistant.CreateDoubleMultiArray(M, N);
            assistant.FillMultiArray(ref array, -20, 30);
            assistant.PrintArray(array);
        }
        else
        {
            Console.WriteLine("Enter two numbers");
            Task47();
        }
    }
    private void Task50()
    {
        Console.WriteLine("A program that takes the position of an element in a two-dimensional array as input," +
         "and returns the value of this element or an indication that there is no such element");
        int row = 10;
        int column = 10;
        double[,] array = assistant.CreateDoubleMultiArray(row, column);
        assistant.FillMultiArray(ref array, -20, 30);
        double[] value = assistant.TakeArrayInConsole("Enter element");
        if (value.Length % 2 == 0)
        {
            for (int i = 0; i < value.Length - 1; i++)
            {
                if (value[i] < row && column > value[i + 1])
                {
                    Console.WriteLine($"array element {value[i]}, {value[i + 1]} = {array[(int)value[i], (int)value[i + 1]]}");
                    assistant.PrintArray(array);
                }
                else
                {
                    Console.WriteLine("there is no such number in the array");
                    assistant.PrintArray(array);
                }
            }
            
        }
        else
        {
            Console.WriteLine("Enter two numbers");
            Task50();
        }

    }
    private void Task52()
    {
        Console.WriteLine("The program is a two-dimensional array of integers. Find the arithmetic mean of the elements in each column");
        int row = 3;
        int column = 3;
        double[,] array = assistant.CreateDoubleMultiArray(row, column);
        assistant.FillMultiArray(ref array, 0, 30);
        for (int j = 0; j < column; j++)
        {
            double average = 0;
            for (int i = 0; i < row; i++)
            {
                average += array[i, j];
                Console.Write($"array = {array[i, j]}\n");
            }
            average /= column;
            Console.Write($"Average = {average}\n\n");
        }
    }


}