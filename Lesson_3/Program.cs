using System;

//var numbers = sNumbers?.Split(',')?.Select(Int32.Parse)?.ToList();

void Distance(Coodin s)//Class Double check need
{
    double x1 = 3, y1 = 6, z1 = 8;
    double x2 = 2, y2 = 1, z2 = -7;
    double distance = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z1 - z2), 2));
    Console.Write($"POW = {distance}\n");
}

void CoubTab(int N)
{
    double result = Math.Pow(N, 3);
    if(N > 0){
        CoubTab(N -=1);
        Console.WriteLine(result);
    }
}

void Polidrom()
{
    int polindrom = 23432;
    int temp = polindrom;
    while (temp > 999)
    {
        temp /= 10;
    }
    int tail = polindrom - (temp * 100);
    temp /= 10;
    Console.Write(((tail % 10) == (temp / 10) && (tail / 10) == (temp % 10)) ? $"YES\n" : $"NO\n");
}


//Distance();
CoubTab(5);
//Polidrom();
struct Coodin{
    public Coodin(double x, double y, double z)
    {
        X = x;
        Y = y;
        Z = z;
    }

    public double X { get; }
    public double Y { get; }
    public double Z { get; }

}