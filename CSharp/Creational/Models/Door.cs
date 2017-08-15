using System;

namespace CreationalPatterns.Models
{
    public class Door : MapSite
    {
        private Room _room1;

        private Room _room2;

        private bool _isOpen;

        public Door(Room room1, Room room2)
        {
            _room1 = room1;
            _room2 = room2;
        }

        public Room OtherSideFrom(Room room)
        {
            throw new NotImplementedException();
        }

        public override void Enter()
        {
            Console.WriteLine("You cannot enter a door, silly.");
        }
    }
}