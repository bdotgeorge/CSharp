using LessonFour;

int TakeConsoleInt(string str = "Enter integer"){
    Console.Write($"{str}\n");
    return StrToInt(Console.ReadLine()!);
}

int StrToInt(string str){
    int num = 0;
    int.TryParse(str, out num);
    return num;
}

double DegreeOf(int number, int degree){
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

int SumNumInteger(int number){
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

int[] CreateArray(int sizeArray = 8){
    int[] tempArray = new int[sizeArray];
    return tempArray;
}
void fillArray(ref int[] array){
    int size = array.Length;
    for(int i = 0; i < size; i++){
        array[i] = new Random().Next(0, 15);
    }
}

void PrintArray(Array massive){
    int size = massive.Length;
    for(int i = 0; i < size; i++){
        Console.Write($"{massive.GetValue(i)}\n");
    }
}
int[] r = CreateArray();
fillArray(ref r);
PrintArray(r);
Lesson lessonFour = new Lesson();
//lessonFour.

//Console.Write($"{SumNumInteger(-9012)}\n");