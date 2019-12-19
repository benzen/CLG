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
        InCounter(a);
        Console.WriteLine(a.GetCounter());

        var a2 = new C();
        InCounter(a2); //05-polymorphisme.cs(35,20): error CS1503: Argument 1: cannot convert from 'C' to 'B'
        Console.WriteLine(a2.GetCounter());
    }

    static private void InCounter(B b){
      b.IncCounter();
    }
}
