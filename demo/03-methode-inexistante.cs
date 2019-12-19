using System;

public class A
{
  protected String value;

  public A()
  {
    this.value = "A";
  }

  public String GetValue()
  {
     return this.value;
  }
}

public class B : A
{
  public B()
  {
    this.value = "B";
  }
  public void printSomething()
  {
    Console.WriteLine("Something");
  }
}

public class Example
{
    public static void Main(string[] args)
    {
        A a = new B();
        Console.WriteLine(a.GetValue());

        a.printSomething(); // 03-errornous-simple-polymorphisme.cs(31,11): error CS1061: 'A' does not contain a definition for 'printSomething'
    }
}
