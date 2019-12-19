using System;

interface A
{
  public int GetCounter();
  public void IncCounter();
}

public class B : A
{
  private int counter;
  public B()
  {
    this.counter = 10;
  }
  public int GetCounter()
  {
    return this.counter;
  }
  public void IncCounter()
  {
    this.counter = this.counter + 1;
  }
}

public class C : A
{
  private int counter;
  public C()
  {
    this.counter = 10;
  }
  public int GetCounter()
  {
    return this.counter;
  }
  public void IncCounter()
  {
    this.counter = this.counter + 10;
  }
}

public class Example
{
    public static void Main(string[] args)
    {
        A a = new B();
        a.IncCounter();
        Console.WriteLine(a.GetCounter());// will print 11

        A a2 = new C();
        a2.IncCounter();
        Console.WriteLine(a2.GetCounter()); /// will print 20

    }
}
