namespace Second_task;

using System.Collections;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(String[] args)
    {
        try
        {
            File.ReadAllLines("Test.txt").Where(x => x[0] == x[^1]).ToList().ForEach(x => Console.WriteLine(x));
        }
        catch (Exception e)
        {
            Console.WriteLine("The process failed: {0}", e.ToString());
        }
    }
}