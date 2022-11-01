using System;
class BaseClass
{
    public virtual void Output()
    {
        Console.WriteLine("In the Base class ...");
    }
}
class DerivedClass : BaseClass
{
    public override void Output()
    {
        Console.WriteLine("In the Derived class ...");
    }
}
class PolymorphismApp
{
    static void Print(BaseClass obj)
    {
        obj.Output();
    }
    public static void Main()
    {
        BaseClass obj1 = new BaseClass();
        DerivedClass obj2 = new DerivedClass();
        Print(obj1);
        Print(obj2);
    }
}
