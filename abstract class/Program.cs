using System;
abstract class AbstractClass
{
    public abstract void MethodA();
    public void MethodB()
    {
        Console.WriteLine("Implementation of MethodB()");
    }
}
class ImpClass : AbstractClass
{
    // 추상 메소드 구현
    override public void MethodA()
    {
        Console.WriteLine("Implementation of MethodA()");
    }
}
class AbstractClassApp
{
    public static void Main()
    {
        ImpClass obj = new ImpClass();
        obj.MethodA();
        obj.MethodB();
    }
}