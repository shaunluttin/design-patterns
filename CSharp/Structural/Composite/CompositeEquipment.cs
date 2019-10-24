using System.Collections.Generic;
using System.Linq;

// "CompisiteEquipment is the base class for equipment that contains
// other equipment." (Gamma et al, 1994)
public abstract class CompositeEquipment : Equipment
{
    private List<Equipment> _equipment = new List<Equipment>();

    public void Add(Equipment e)
    {
        _equipment.Add(e);
    }

    public override decimal NetPrice()
    {
        return _equipment.Sum((e) => e.NetPrice());
    }
}
