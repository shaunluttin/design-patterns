namespace Composite
{
    public class ComputerAssembler
    {
        // The AssembleComputer class is the client for the composite pattern.
        public void AssembleComputer()
        {
            var cabinet = new Cabinet("PC Cabinet", 25M);
            var chassis = new Chassis("PC Chassis", 50M);

            cabinet.Add(chassis);

            var bus = new Bus("MCA Bus", 100M);
            bus.Add(new Card("16 Mbs Token Ring", 100M));
            chassis.Add(bus);

            chassis.Add(new FloppyDisk("3.5 in Floppy", 100M));

            // cabinet
            //   > chassis > bus > card
            //   > floppy disc
            System.Console.WriteLine($"The net price is ${cabinet.NetPrice()}");
        }
    }
}
