using System.ComponentModel.Design;

namespace P4_1Replacing;

public class Plant
{
    public bool isGrown;

    public void printStatus()
    {
        if (this.isGrown)
        {
            Console.WriteLine("Plant is a a tree!");
        }
        else
        {
            Console.WriteLine("Plant is a seed!");
        }
    }

    public void Grow()
    {
        if (isGrown)
        {
            Console.WriteLine("Plant has already grown.");
            return;
        }
        
        Console.WriteLine("Plant is Growing.");
        this.isGrown = true;
    }
    
}