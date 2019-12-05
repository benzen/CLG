using System;

public class A {
  public void PrintSomething() {
     Console.WriteLine("A: They asked me to print, so here it is");
  }
}

public class B : A {
  public void PrintSomething(){ // 04-errornous-polymorphisme.cs(10,15): warning CS0108: 'B.PrintSomething()' hides inherited member 'A.PrintSomething()'. Use the new keyword if hiding was intended.
    Console.WriteLine("B: I'me better than thoses A instances.");
  }
}

public class Example
{
    public static void Main(string[] args)
    {
        var a = new B();
        a.PrintSomething();
        // Will print "B: I'm better than thoses A instances."
    }
}
