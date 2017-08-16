namespace CreationalPatterns.Models
{
    public class EnchantedRoom : Room
    {
        private Spell _spell;

        public EnchantedRoom(int n, Spell spell): base(n)
        {
            _spell = spell;
        }
    }
}