public class FloppyDisk : Equipment
{
    private string v;

    public FloppyDisk(string v)
    {
        this.v = v;
    }


    public override decimal NetPrice()
    {
        throw new System.NotImplementedException();
    }
}