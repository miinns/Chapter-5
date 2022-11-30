using System;
class BaseClass
{
    public void MethodA()
    {
        Console.WriteLine("In BaseClass ...");
    }
}
class DerivedClass : BaseClass
{
    // Overriding(재정의)
    new public void MethodA()
    { 
        Console.WriteLine("In DerivedClass ... Overriding !!!");
    }

    // Overloading(중복)
    public void MethodA(int i)
    {
        Console.WriteLine("In DerivedClass ... Overloading !!!");
    }
}
class OverridingAndOverloadingApp
{
    public static void Main()
    {
        BaseClass obj1 = new BaseClass();
        DerivedClass obj2 = new DerivedClass();
        obj1.MethodA();
        obj2.MethodA(); // 인자 없는 호
        obj2.MethodA(1); 
    }
}
