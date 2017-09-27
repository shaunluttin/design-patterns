using CreationalPatterns.Models;

namespace CreationalPatterns.FactoryMethod
{
    public class EnchantedMazeGame : MazeGame
    {
        protected override Room MakeRoom(int n)
        {
            return new EnchantedRoom(n, CastSpell());
        }

        protected override Door MakeDoor(Room room1, Room room2)
        {
            return new DoorNeedingSpell(room1, room2);
        }

        public Spell CastSpell()
        {
            return new Spell();
        }
    }
}
