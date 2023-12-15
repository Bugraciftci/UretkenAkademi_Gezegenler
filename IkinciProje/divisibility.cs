using System;
using System.Collections.Generic;

public class Divisibility
{
    public static void bolenleriBul(int ilkSayı, int SonSayı)
    {
        List<int> ikiyeBolunenler = new List<int>();
        List<int> uceBolunenler = new List<int>();
        List<int> dorteBolunenler = new List<int>();
        List<int> beseBolunenler = new List<int>();

        for (int i = ilkSayı; i <= SonSayı; i++)
        {
            if (i % 2 == 0)
            {
                ikiyeBolunenler.Add(i);
            }
            if (i % 3 == 0)
            {
                uceBolunenler.Add(i);
            }
            if (i % 4 == 0)
            {
                dorteBolunenler.Add(i);
            }
            if (i % 5 == 0)
            {
                beseBolunenler.Add(i);
            }
        }

        Console.WriteLine("ikiye bölünenler = " + string.Join(",", ikiyeBolunenler));
        Console.WriteLine("üçe bölünenler = " + string.Join(",", uceBolunenler));
        Console.WriteLine("dörde bölünenler = " + string.Join(",", dorteBolunenler));
        Console.WriteLine("beşe bölünenler = " + string.Join(",", beseBolunenler));
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Divisibility.bolenleriBul(1, 100);
    }
}
