using System;

class Student
{
    public string Name;
    public int Grade1;
    public int Grade2;
    public int Grade3;

    public double GetAverage()
    {
        return (Grade1 + Grade2 + Grade3) / 3.0;
    }
    public string GetLetterGrade()
    {
        double avg = GetAverage();

        if (avg >= 90) return "A";
        if (avg >= 75) return "B";
        if (avg >= 60) return "C";
        return "F";
    }
    public void Print()
    {
        Console.WriteLine(Name + " Avg: " + GetAverage() + " Grade: " + GetLetterGrade());
    }
}



class Program
{
    static void Main()
    {
        Student[] roster = new Student[4];

        roster[0] = new Student { Name = "A", Grade1 = 90, Grade2 = 80, Grade3 = 85 };
        roster[1] = new Student { Name = "B", Grade1 = 70, Grade2 = 75, Grade3 = 72 };
        roster[2] = new Student { Name = "C", Grade1 = 95, Grade2 = 90, Grade3 = 100 };
        roster[3] = new Student { Name = "D", Grade1 = 60, Grade2 = 65, Grade3 = 63 };

        foreach (Student s in roster)
        {
            s.Print();
        }

        Student best = roster[0];

        foreach (Student s in roster)
        {
            if (s.GetAverage() > best.GetAverage())
            {
                best = s;
            }
        }

        Console.WriteLine("Best student:");
        best.Print();
    }
}