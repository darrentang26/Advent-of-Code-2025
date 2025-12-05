using System;
using System.IO;
using System.Collections;

public class Day2
{
    public static void main(string[] args)
    {
        int sum = 0;
        List<int> invalids = new List<int>();
        
        using (StreamReader sr = new StreamReader("../Input.txt"))
        {
            string Input = fs.ReadLine();
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

    internal List<int> FindInvalidIDsInRange(string range)
    {
        string bounds = range.Split("-");
        int lower = int.parse(bounds[0]);
        int upper = int.parse(bounds[1]);
        List<int> invalids = new List<int>();
        for (int i = lower; i <= upper; i++)
        {
            if (FullyRepeats(i.ToString()))
            {
                invalids.add(i);
            }
        }
        return invalids;
    }

    internal bool FullyRepeats(string ID)
    {
        
    }
}