using System;
using System.IO;

public class Day2
{
    public static void main(string[] args)
    {
        using (StreamReader sr = new StreamReader("../Input.txt"))
        {
            string Input = fs.ReadLine();
            string[] ranges = Input.Split(',');
            foreach(string range in ranges)
            {
                
            }
        }
    }

    public int[] FindInvalidIDs(string range)
    {
        string bounds = range.Split("-");
        int lower = int.parse(bounds[0]);
        int upper = int.parse(bounds[1]);
    }
}