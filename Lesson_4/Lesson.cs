namespace LessonFour;
public class Lesson
{
    /*private string data = string.Empty;
    
    public Lesson(string value)
    {
        data = value;
    }*/
    

    public void PrintArray(Array massive){
        int size = massive.Length;
        for(int i = 0; i < size; i++){
            Console.Write($"Print Array data {i} = {massive.GetValue(i)}\n");
        }
    }
    public int[] TaskTwentyNineCreateArray(int sizeArray = 8){
        int[] tempArray = new int[sizeArray];
        return tempArray;
    }
    public void fillArray(ref int[] array){
        int size = array.Length;
        for(int i = 0; i < size; i++){
            array[i] = new Random().Next(0, size);
        }
    }
    public void EnterTaskNumber(){
        int taskNumber = TakeConsoleInt("Enter task number");
        switch (taskNumber)
        {
            case 25:
                Console.WriteLine("The program takes two numbers (A and B) as input and raises the number A to the natural power of B.");
                Console.Write($"Result work task 25 = {TaskTwentyFiveDegreeOf(TakeConsoleInt("Enter A number"), TakeConsoleInt("Enter B degree"))}\n");
                break;
            case 27:
                Console.WriteLine("The program takes a number as input and returns the sum of the digits in the number.");
                Console.Write($"Result work task 27 = {TaskTwentySevenSumNumInteger(TakeConsoleInt())}\n");
                break;
            case 29:
                Console.WriteLine("The program sets an array of 8 elements and displays them on the screen");
                int[] mas = TaskTwentyNineCreateArray();
                fillArray(ref mas);
                PrintArray(mas);
                break;
            default:
                Console.Write($"Wrong task number \n");
                break;
        }
    }
    private int TakeConsoleInt(string str = "Enter integer"){
        Console.Write($"{str}\n");
        return StrToInt(Console.ReadLine()!);
    }

    private int StrToInt(string str){
        int num = 0;
        int.TryParse(str, out num);
        return num;
    }

    private double TaskTwentyFiveDegreeOf(int number, int degree){
        double result = number;
        if(degree > 0){
            for (int i = 1; i < degree; i++) {
                result *= number;
            }
        }
        else{
            for (int i = degree; i <= 0; i++) {
                result /= number;
            }
        }
        return result;
    }

    private int TaskTwentySevenSumNumInteger(int number){
        number = Math.Abs(number);
        string str = number.ToString();
        int size = str.Length;
        int sum = number % 10;
        for (int i = 0; i < size; i++)
        {
            number /= 10;
            sum += number % 10;
        }
        return sum;
    }

    
}
