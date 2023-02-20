using System;
using System.Collections.Generic;
using System.Linq;
//var numbers = sNumbers?.Split(',')?.Select(Int32.Parse)?.ToList();


namespace Program
{
    class Lesson_3
{
static void CoubTab(int N){
    double result = Math.Pow(N, 3);
    if(N > 0){
        CoubTab(N -=1);
        Console.WriteLine(result);
    }
    }
    static void Palidrom(int palindrom){
        int temp = palindrom;
        while (temp > 999)
        {
            temp /= 10;
        }
        palindrom = palindrom - (temp * 100);
        temp /= 10;
        Console.Write(((palindrom % 10) == (temp / 10) && (palindrom / 10) == (temp % 10)) ? $"YES\n" : $"NO\n");
    }

static int stringToInt(ref string value){
    int number;
    int.TryParse(value, out number);
    return number;
}
static void Distance(Coordinate pFirst, Coordinate pSecond){
    double x1 = pFirst.X, y1 = pFirst.Y, z1 = pFirst.Z;
    double x2 = pSecond.X, y2 = pSecond.Y, z2 = pSecond.Z;
    double distance = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z1 - z2), 2));
    Console.Write($"POW = {distance}\n");
}
public static List<double> ParserTextToDouble(string text){
    List<double> result;
    result = text?.Split(',')?.Select(Double.Parse)?.ToList();
    return result;
}

public static List<int> ParserTextToInt(string text){
    List<int> result;
    result = text?.Split(',')?.Select(Int32.Parse)?.ToList();
    return result;
}

public static bool validList(int lenght){
    if((lenght % 6) != 0 || lenght < 4)
         return false;
    return true;
}
struct Coordinate{
    public Coordinate(double x, double y, double z)
    {
        X = x;
        Y = y;
        Z = z;
    }
    public double X { get; }
    public double Y { get; }
    public double Z { get; }

}

static void TaskTwentiSix(){
        Console.WriteLine("Enter the coordinates of the first point(in X Y Z format)");
        string str = Console.ReadLine()!;
        Console.WriteLine("Enter the coordinates of the second point(in X Y Z format)");
        str =  str + ',' +  Console.ReadLine()!;
         Console.WriteLine(str);
        List<double> data = ParserTextToDouble(str);
        if(validList(data.Count)){
            int size = data.Count -5;
            for (int i = 0; i < size; i += 6)
            {
                Coordinate pointFirst = new Coordinate(data[i], data[i + 1], data[i + 2]);
                Coordinate pointSecond = new Coordinate(data[i + 3], data[i + 4], data[i + 5]);
                Distance(pointFirst, pointSecond);
            }

        }
        else{
               string value = "";
               for(int i = 0; i < data.Count; i++){
                if((i % 3) == 0)
                    value += "\nPoint: ";
                value += data[i].ToString() + ", ";
               }
               value += ".";
               Console.Write($"Error in coordinates {value}");
        }
}
static void TaskPalidrom(){
        Console.WriteLine("Уnter an integer to test for a palindrome");
        string p = Console.ReadLine()!;
        Palidrom(stringToInt(ref p));
}

static void TaskCoub(){
        string p = Console.ReadLine()!;
        CoubTab(stringToInt(ref p));
}
    static void Main()
    {

        TaskTwentiSix();
        TaskPalidrom();
        TaskCoub();
        
    }

}
}




