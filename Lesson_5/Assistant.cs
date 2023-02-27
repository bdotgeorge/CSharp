namespace AssistantClass;
public class Assistant
{
    public void PrintArray(Array massive)
    {
        int size = massive.Length;
        for(int i = 0; i < size; i++){
            Console.Write($"Print Array data {i} = {massive.GetValue(i)}\n");
        }
    }
    public int[] CreateIntArray(int sizeArray = 8)
    {
        int[] tempArray = new int[sizeArray];
        return tempArray;
    }
    public void FillArray(ref int[] array, int from = 0, int to = 10)
    {
        int size = array.Length;
        for(int i = 0; i < size; i++){
            array[i] = new Random().Next(from, to);
        }
    }
    
    public int TakeConsoleInt(string str = "Enter integer"){
        Console.Write($"{str}\n");
        return StrToInt(Console.ReadLine()!);
    }

    private int StrToInt(string str){
        int num = 0;
        int.TryParse(str, out num);
        return num;
    }
}