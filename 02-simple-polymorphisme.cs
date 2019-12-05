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
        A a = new B();
        Console.WriteLine(a.GetValue());
        // Should print "B"
    }
}
