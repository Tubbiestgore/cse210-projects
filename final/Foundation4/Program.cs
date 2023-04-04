using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> list = new List<Activity>();

        Cycling cycling = new Cycling(45, 16);
        list.Add(cycling);
        Running running = new Running(30, 3);
        list.Add(running);
        Swimming swimming = new Swimming(60, 40);
        list.Add(swimming);

        foreach (Activity activity in list)
        {
            activity.GetSummary();
        }
    }
}