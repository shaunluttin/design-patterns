public class ConcreteBuilder : AbstractBuilder
{
    private Product _product;

    public ConcreteBuilder()
    {
        _product = new Product();
    }

    public override void AddLeftArm()
    {
        _product.Parts.Add("Left Arm");
    }

    public override void AddRightArm()
    {
        _product.Parts.Add("Right Arm");
    }

    public Product GetResult()
    {
        return _product;
    }
}