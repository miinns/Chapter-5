using System;
class BaseClass
{
    virtual public void MethodA()
    {
        Console.WriteLine("Base MethodA");
    }
    virtual public void MethodB()
    {
        Console.WriteLine("Base MethodB");
    }
    virtual public void MethodC()
    {
        Console.WriteLine("Base MethodC");
    }
}
class DerivedClass : BaseClass
{
    new public void MethodA()
    {
        Console.WriteLine("Derived MethodA");
    }
    override public void MethodB()
    {
        Console.WriteLine("Derived MethodB");
    }
    public void MethodC()
    {
        Console.WriteLine("Derived MethodC");
    }
}
class VirtualMethodApp
{
    public static void Main()
    {
        BaseClass s = new DerivedClass();
        s.MethodA(); 
        s.MethodB(); // s가 가리키는 객체(파생클래스)의 MethodB()가 호출
        s.MethodC(); // s 객체의 MathodC()가 호출
    }
}
