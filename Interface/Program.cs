using System;
interface A
{
    void say();
    int prop
    {
        get;
        set;
    }
}

class X : A
{
    public int b;
    public void say()
    {
        Console.WriteLine("Hello");
    }
    public int prop
    {
        get
        {
            return b;
        }
        set
        {
            b = value;
        }
    }
}

class IF
{
    static void Main()
    {
        X x = new X();
        x.say();
        x.prop = 52;
        Console.WriteLine(x.prop);
    }
}