using System;
using System.Diagnostics.CodeAnalysis;

namespace CreationalPatterns.Models
{
    public class Door : MapSite
    {
        private Room _room1;

        private Room _room2;

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

        #region Support the Prototype pattern.

        [SuppressMessage(
            "StyleCop.Analyzers",
            "SA1201:ElementsMustAppearInTheCorrectOrder",
            Justification = "Support the use of regions.")]
        public Door(Door other)
        {
            _room1 = other._room1;
            _room2 = other._room2;
        }

        public virtual Door Clone()
        {
            return new Door(this);
        }

        public void Initialize(Room room1, Room room2)
        {
            _room1 = room1;
            _room2 = room2;
        }

        #endregion
    }
}
