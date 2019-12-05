using System;

public class A {
  protected int counter;
  public A(){
    counter = 0;
  }
  public int GetCounter(){
    return counter;
  }
  public void IncCounter(){
    counter = counter + 1;
  }

}

public class B : A {
}

public class C : A {
  public C(){
    counter = 10;
  }
  public new void IncCounter(){
    base.IncCounter();
    Console.WriteLine("C: My new value is " + this.counter);
  }
}

public class Example
{
    public static void Main(string[] args)
    {
        var a = new B();
        a.IncCounter();
        Console.WriteLine(a.GetCounter());

        var a2 = new C();
        a2.IncCounter();
        Console.WriteLine(a2.GetCounter());
    }


}
