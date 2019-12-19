using System;

public class A
{
  protected int counter;
  public A()
  {
    counter = 0;
  }
  public int GetCounter()
  {
    return counter;
  }
  public void IncCounter()
  {
    counter = counter + 1;
  }
}

public class B : A
{
}

public class C : A
{
  public C()
  {
    counter = 10;
  }
}

public class Example
{
    public static void Main(string[] args)
    {
        var a = new B();
        IncCounter(a);
        Console.WriteLine(a.GetCounter());
        // Will print "1"

        var a2 = new C();
        IncCounter(a2);
        Console.WriteLine(a2.GetCounter());
        // will print 11
    }

    static private void IncCounter(A a)
    {
      a.IncCounter();
    }
}
