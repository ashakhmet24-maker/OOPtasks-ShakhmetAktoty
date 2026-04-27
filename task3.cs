using System;

class Temperature
{
    private double _celsius;
    private double _fahrenheit; // лишнее поле (ошибка идеи)

    public double Celsius
    {
        get { return _celsius; }
        set
        {
            if (value < -273)
            {
                Console.WriteLine("too low"); // ошибка: нет throw
            }
            _celsius = value;
        }
    }

    public double Fahrenheit
    {
        get { return _fahrenheit; } // ошибка: не вычисляется
        set
        {
            _fahrenheit = value;
            _celsius = (value - 32) * 5 / 9;
        }
    }

    public Temperature(double c)
    {
        _celsius = c;
    }

    public void Print()
    {
        Console.WriteLine(_celsius + "C " + _fahrenheit + "F");
    }
}

class Program
{
    static void Main()
    {
        Temperature t = new Temperature(25);
        t.Print();

        t.Fahrenheit = 100;
        t.Print();

        t.Celsius = -300; // не кидает ошибку
        t.Print();
    }
}