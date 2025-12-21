using System;
using System.IO;
using System.Collections;

public class Day2
{
    public static void Main(string[] args)
    {
        int sum = 0;
        List<int> invalids = new List<int>();
        
        using (StreamReader sr = new StreamReader("../Input.txt"))
        {
            string Input = sr.ReadLine();
            string[] ranges = Input.Split(',');
            foreach(string range in ranges)
            {
                invalids.AddRange(FindInvalidIDsInRange(range));
                foreach (int i in invalids)
                {
                    sum += i;
                }
            }
        }
        
        Console.WriteLine("Invalid Sums: " + sum.ToString());
    }

    internal static List<int> FindInvalidIDsInRange(string range)
    {
        string[] bounds = range.Split("-");
        int lower = int.Parse(bounds[0]);
        int upper = int.Parse(bounds[1]);
        List<int> invalids = new List<int>();
        for (int i = lower; i <= upper; i++)
        {
            if (FullyRepeats(i.ToString()))
            {
                invalids.Add(i);
            }
        }
        return invalids;
    }

    internal static bool FullyRepeats(string ID)
    {
        for (int i = 0; i < ID.Length / 2; i++)
        {
            string toMatch = ID.Substring(0, i + 1);
            if (ID.Length % toMatch.Length == 0)
            {
                for (int j = i; j < (ID.Length / toMatch.Length); j *= toMatch.Length)
                {
                    if (ID.Substring(j,toMatch.Length) != toMatch)
                    {
                        return false;
                    }
                }
            }
        }
        return true;
    }
}