using System;

public class A {
  public void PrintSomething() {
     Console.WriteLine("A: They asked me to print, so here it is");
  }
}

public class B : A {
  public new void PrintSomething(){
    Console.WriteLine("B: I'me better than thoses A instances.");
  }
}

public class Main
{
    public static void Main(string[] args)
    {
        var a = new B();
        a.PrintSomething();
        // Will print "B: I'm better than thoses A instances."
    }
}
