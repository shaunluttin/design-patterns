namespace CreationalPatterns.Models
{
    public class EnchantedRoom : Room
    {
        private Spell _spell;

        public EnchantedRoom(int n, Spell spell) : base(n)
        {
            _spell = spell;
        }

        #region Support the Prototype pattern.

        public EnchantedRoom(EnchantedRoom other) : base(other)
        {
            _spell = other._spell;
        }

        public override Room Clone()
        {
            return new EnchantedRoom(this);
        }

        #endregion
    }
}