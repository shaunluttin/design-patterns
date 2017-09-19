public class FloppyDisk : Equipment
{
    private string _name;

    public FloppyDisk(string name)
    {
        this._name = name;
    }


    public override decimal NetPrice()
    {
        return 100M;
    }
}