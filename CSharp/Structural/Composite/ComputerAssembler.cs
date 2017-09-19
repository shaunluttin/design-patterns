namespace Composite
{
    public class ComputerAssembler
    {
        // The AssembleComputer class is the client for the composite pattern.
        public void AssembleComputer()
        {
            var cabinet = new Cabinet("PC Cabinet");
            var chassis = new Chassis("PC Chassis");

            cabinet.Add(chassis);

            var bus = new Bus("MCA Bus");
            bus.Add(new Card("16 Mbs Token Ring"));
            chassis.Add(bus);

            chassis.Add(new FloppyDisk("3.5 in Floppy"));

            // cabinet              $100
            //   chassis            $100
            //     bus              $100
            //       card           $100
            //   floppy disc        $100
            //                      ----
            //                      $500
            System.Console.WriteLine($"The net price is {cabinet.NetPrice()}");
        }
    }
}
