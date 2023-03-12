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
            case 64:
                Task64();
                EnterTaskNumber();
                break;
            case 66:
                Task66();
                EnterTaskNumber();
                break;
            case 68:
                Task68();
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
        Console.WriteLine("A program that will output a three-dimensional array line by line, adding the indices of each element");
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
                    from += 10;
                    to += 10;
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
        Console.WriteLine("A program that will find the product of two matrices.");
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
        Console.WriteLine("A program that sorts in descending order the elements of each row of a two-dimensional array");
        double[,] mas = assistant.CreateDoubleMultiArray();
        assistant.FillMultiArray(ref mas);
        assistant.PrintArray(mas);
        Console.WriteLine("Sorting mass");
        for (int i = 0; i < mas.GetLength(0); i++)
        {
            assistant.SortArray(ref mas, i, false);
        }
        assistant.PrintArray(mas);
    }
    private void Task56()
    {
        Console.WriteLine("A program that will find the string with the smallest sum of elements.");
        var mas = assistant.CreateDoubleMultiArray();
        assistant.FillMultiArray(ref mas);
        assistant.PrintArray(mas);
        (int, double) sum = (0, Double.MaxValue);
        for (int i = 0; i < mas.GetLength(0); i++)
        {
            double temp = 0;
            for (int j = 0; j < mas.GetLength(1); j++)
            {
                temp += mas[i, j];
            }
            if (sum.Item2 > temp)
            {
                sum = (i, temp);
            }
        }
        Console.Write($"row = {sum.Item1 + 1}\nsum row = {sum.Item2}\n");
    }
    private void Task62()
    {
        Console.WriteLine("A program that will fill a spiral array.");
        int sizeMatrix = 5;
        var mas = assistant.CreateIntMultiArray(sizeMatrix, sizeMatrix);
        spiral(ref mas);
        int max = assistant.findMaxSizeElement(ref mas);
        for (int i = 0; i < mas.GetLength(0); i++)
        {
            for (int j = 0; j < mas.GetLength(1); j++)
            {
                if (mas[i, j] < 10)
                {
                    Console.Write($"0{mas[i, j]} ");
                }
                else
                {
                    Console.Write($"{mas[i, j]} ");
                }

            }
            Console.WriteLine();
        }
    }
    private void spiral(ref int[,] array)
    {
        int size = array.GetLength(0);
        if (size != array.GetLength(1))
            return;
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                int row = i + 1;
                int column = j + 1;
                int switcher = (column - row + size) / size;
                int ic = Math.Abs(row - size / 2 - 1) + (row - 1) / (size / 2) * ((size - 1) % 2);
                int jc = Math.Abs(column - size / 2 - 1) + (column - 1) / (size / 2) * ((size - 1) % 2);
                int ring = size / 2 - (Math.Abs(ic - jc) + ic + jc) / 2;
                int xs = row - ring + column - ring - 1;
                int coefficient = 4 * ring * (size - ring);
                array[i, j] = coefficient + switcher * xs + Math.Abs(switcher - 1) * (4 * (size - 2 * ring) - 2 - xs);
            }
        }
    }
    private void Task64()
    {
        Console.WriteLine("A program that displays all natural numbers between N and 1 or -1 for negative numbers. With the help of recursion.");
        int N = 8;
        Console.Write($"{FromNTo(N)}");
        Console.WriteLine();
    }

    private string FromNTo(int N)
    {
        string result;
        if (N > 0)
        {
            result = FromNToP(N);
        }
        else if (N < 0)
        {
            result = FromNToN(N);
        }
        else
        {
            result = N.ToString();
        }
        return result;
    }

    private string FromNToP(int value, int to = 1)
    {
        if (value == to)
            return value.ToString();
        return $"{value.ToString()}, {FromNToP(value - 1, to)}";
    }

    private string FromNToN(int value, int to = -1)
    {
        if (value == to)
            return value.ToString();
        return $"{value.ToString()}, {FromNToN(value + 1, to)}";
    }
    private void Task66()
    {
        Console.WriteLine("A program that finds the sum of natural elements in the interval from M to N.");
        int M = 4;
        int N = 8;
        int sum = FindSumFromTo(M, N);
        Console.Write($"{sum}");
        Console.WriteLine();
    }

    private int FindSumFromTo(int begin, int end)
    {
        if (begin == end - 1)
            return begin + end;
        return begin + FindSumFromTo(begin + 1, end);
    }
    private void Task68()
    {
        Console.WriteLine("Ackerman function calculation program using recursion");
        uint m = 3;
        uint n = 2;
        uint result = Ackerman(m, n);
        Console.Write($"{result}");
        Console.WriteLine();

    }
    private uint Ackerman(uint first, uint second)
    {
        while (first != 0)
        {
            if (second == 0)
            {
                second = 1;
            }
            else
            {
                second = Ackerman(first, second - 1);

            }
            first = first - 1;
        }
        return second + 1;
    }


}