using System;

public class A
{
  public virtual void PrintSomething()
  {
     Console.WriteLine("A: They asked me to print, so here it is");
  }
}

public class B : A
{
  public override void PrintSomething()
  {
    Console.WriteLine("B: I'me better than thoses A instances.");
  }
}

public class Example
{
    public static void Main(string[] args)
    {
        B b = new B();
        b.PrintSomething();
        // Will print "B: I'm better than thoses A instances."

        A ab = new B();
        ab.PrintSomething();
        // Will print "B: I'm better than thoses A instances."
    }
}
