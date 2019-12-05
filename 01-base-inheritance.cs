using System;

public class A {
  protected String value;

  public A(){
    this.value = "A";
  }

  public String GetValue() {
     return this.value;
  }
}

public class B : A {
  public B(){
    this.value = "B";
  }
}

public class Example
{
    public static void Main(string[] args)
    {
        B b = new B();
        Console.WriteLine(b.GetValue());
        // Will print "B"
    }
}
