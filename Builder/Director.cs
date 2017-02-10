public class Director 
{
    private AbstractBuilder _builder;

    public Director(AbstractBuilder builder)
    {
        _builder = builder;
    }

    public void BuildProductWithTwoArms()
    {
        _builder.AddLeftArm();
        _builder.AddRightArm(); 
    }
}