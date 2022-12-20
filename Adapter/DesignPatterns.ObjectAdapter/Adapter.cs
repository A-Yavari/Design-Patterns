namespace DesignPatterns.ObjectAdapter;

public class Adapter : Target
{
    private Adaptee adaptee;
    public Adapter()
    {
        adaptee = new Adaptee();
    }
    public override void Operation()
    {
        adaptee.SpecificOperation();
    }
}
