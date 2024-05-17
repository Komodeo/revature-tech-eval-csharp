// Example abstract classes and class members

public class D
{
    public virtual void DoWork(int i)
    {
        // Original implementation.
    }
}

public abstract class E : D
{
    public abstract override void DoWork(int i); //Overriding a virtual method
}

public class F : E
{
    public override void DoWork(int i)
    {
        // New implementation.
    }
}