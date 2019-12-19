using System;

public class A {
  protected int counter;
  public A(){
    counter = 0;
  }
  public int GetCounter(){
    return counter;
  }
  public virtual void IncCounter(){
    counter = counter + 1;
  }
}

public class B : A {
}

public class C : A {
  public C(){
    counter = 10;
  }
  public override void IncCounter(){
    base.IncCounter();
    Console.WriteLine("C: My new value is " + this.counter);
  }
}

public class Example{
    public static void Main(string[] args)
    {
        A a = new B();
        a.IncCounter();
        Console.WriteLine(a.GetCounter()); // will show 1

        A a2 = new C();
        a2.IncCounter(); //will show C: my new value is 11
        Console.WriteLine(a2.GetCounter()); //will show 11
    }
}
