using System;
public interface IControl
{
    void Paint();
}
public interface ISurface
{
    void Paint();
}
public class SampleClass : IControl, ISurface
{
    //explicit interfa
    void IControl.Paint()
    {
        System.Console.WriteLine("IControl.Paint");
    }
    void ISurface.Paint()
    {
        System.Console.WriteLine("ISurface.Paint");
    }
}
class Program
{
    static void Main(string[] args)
    {
        SampleClass sample = new SampleClass();
        IControl control = sample;  
        ISurface surface = sample; 
        control.Paint(); 
        surface.Paint(); 
        ((IControl)sample).Paint(); 
        ((ISurface)sample).Paint();
    }
}
