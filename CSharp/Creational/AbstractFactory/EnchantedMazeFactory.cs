using CreationalPatterns.Models;

namespace CreationalPatterns.AbstractFactory
{
    public class EnchantedMazeFactory : MazeFactory
    {
        public override Door MakeDoor(Room room1, Room room2)
        {
            return new DoorNeedingSpell(room1, room2);
        }

        public override Room MakeRoom(int n)
        {
            return new EnchantedRoom(n, CastSpell());
        }

        public Spell CastSpell()
        {
            return new Spell();
        }
    }
}
