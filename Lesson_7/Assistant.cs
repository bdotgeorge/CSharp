using System.Linq;
namespace AssistantClass;
public class Assistant
{
    public void PrintArray(Array massive)
    {
        bool stop = true;
        try
        {
            stop = true;
            int row = massive.GetLength(0);
            int column = massive.GetLength(1); ;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    Console.Write($"\nPrint Multi\nArray data i = {i} j = {j}\nvalue = {massive.GetValue(i, j)}; ");
                }
                Console.WriteLine();
            }
        }
        catch (Exception error)
        {
            Console.WriteLine(error.Message
            );
            stop = false;
        }

        if (stop)
            return;

        int size = massive.Length;
        for (int i = 0; i < size; i++)
        {
            Console.Write($"Print Array data {i} = {massive.GetValue(i)}\n");
        }
    }
    public int[,] CreateIntMultiArray(int row = 8, int column = 4)
    {
        int[,] tempArray = new int[row, column];
        return tempArray;
    }

    public double[,] CreateDoubleMultiArray(int row = 8, int column = 4)
    {
        double[,] tempArray = new double[row, column];
        return tempArray;
    }
    public int[] CreateIntArray(int sizeArray = 8)
    {
        int[] tempArray = new int[sizeArray];
        return tempArray;
    }
    public void FillArray(ref int[] array, int from = 0, int to = 10)
    {
        int size = array.Length;
        for (int i = 0; i < size; i++)
        {
            array[i] = new Random().Next(from, to);
        }
    }
    public void FillMultiArray(ref double[,] array, int from = 0, int to = 10)
    {
        int row = array.GetLength(0);
        int column = array.GetLength(1);
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < column; j++)
            {
                array[i, j] = new Random().Next(from, to + 1);
            }
        }
    }
    public int TakeConsoleInt(string str = "Enter integer")
    {
        Console.Write($"{str}\n");
        return StrToInt(Console.ReadLine()!);
    }

    private int StrToInt(string str)
    {
        int num = 0;
        int.TryParse(str, out num);
        return num;
    }
    public double[] TakeArrayInConsole(string str = "Enter integer")
    {
        Console.Write($"{str}\n");
        double[] array = Console.ReadLine()!.Split(',', ' ').Where(i => double.TryParse(i, out _)).Select(double.Parse).ToArray();
        return array;
    }
    //int a = 13;
    //string str = Convert.ToString(a, 2)//hex;
    //text.Split(' ').Where(i => int.TryParse(i, out _)).Select(int.Parse).ToArray();
}