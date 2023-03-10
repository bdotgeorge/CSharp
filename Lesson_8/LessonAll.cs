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
            case 58:
                TaskMatrix58();
                EnterTaskNumber();
                break;
            case 60:
                Task60();
                EnterTaskNumber();
                break;
            case 62:
                Task62();
                EnterTaskNumber();
                break;
            case 56:
                Task56();
                EnterTaskNumber();
                break;
            case 54:
                Task54();
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

    private void Task60()
    {
        int row = 2;
        int column = 2;
        int facet = 2;
        int from = 10;
        int to = 15;
        int[,,] coub = new int[row, column, facet];
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < column; j++)
            {
                for (int k = 0; k < facet; k++)
                {
                    coub[i, j, k] = new Random().Next(from, to);
                    from +=10;
                    to +=10;
                }
            }
        }

        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < column; j++)
            {
                for (int k = 0; k < facet; k++)
                {
                    Console.Write($"Value = {coub[i, j, k]}, index({i},{j},{k}) ");
                }
                Console.WriteLine();
            }
        }
    }

    private void TaskMatrix58()
    {
        double[,] firstM = new double[2, 2] { { 2, 4 }, { 3, 2 } };
        double[,] secondM = new double[2, 2] { { 3, 4 }, { 3, 3 } };
        if (firstM.GetLength(1) != secondM.GetLength(0))
        {
            Console.WriteLine("Error");
            return;
        }
        //assistant.FillMultiArray(ref firstM);
        //assistant.FillMultiArray(ref secondM);
        double[,] matix = sumMatrix(ref firstM, ref secondM);
        for (int i = 0; i < matix.GetLength(0); i++)
        {
            Console.Write($" sum matrix = ");
            for (int j = 0; j < matix.GetLength(1); j++)
            {
                Console.Write($"{matix[i, j]} ");
            }
            Console.WriteLine();
        }
    }

    private double[,] sumMatrix(ref double[,] firstM, ref double[,] secondM)
    {
        double[,] matrix = new double[firstM.GetLength(0), secondM.GetLength(1)];
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                for (int k = 0; k < firstM.GetLength(1); k++)
                {
                    matrix[i, j] += firstM[i, k] * secondM[k, j];
                }
            }
        }
        return matrix;
    }

    private void Task54()
    {

    }
    private void Task56()
    {

    }
    private void Task62()
    {

    }


}