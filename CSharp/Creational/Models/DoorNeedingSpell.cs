namespace CreationalPatterns.Models
{
    public class DoorNeedingSpell : Door
    {
        public DoorNeedingSpell(Room room1, Room room2) : base(room1, room2) { }

        #region Support the Prototype pattern.

        public DoorNeedingSpell(DoorNeedingSpell other) : base(other) { }

        public override Door Clone()
        {
            return new DoorNeedingSpell(this);
        }

        #endregion
    }
}