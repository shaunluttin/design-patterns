public class ComputerAssembler
{
    public void AssembleComputer()
    {
        var cabinet = new Cabinet("PC Cabinet");
        var chassis = new Chassis("PC Chassis");

        cabinet.Add(chassis);

        var bus = new Bus("MCA Bus");
        bus.Add(new Card("16 Mbs Token Ring"));
        chassis.Add(bus);

        chassis.Add(new FloppyDisk("3.5 in Floppy"));

        System.Console.WriteLine($"The net price is {chassis.NetPrice()}");
    }
}