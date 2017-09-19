using System;
using System.Diagnostics.CodeAnalysis;

namespace CreationalPatterns.Models
{
    public class Room : MapSite
    {
        private MapSite[] _sides = new MapSite[4];

        private int _roomNumber;

        public Room(int roomNo)
        {
            _roomNumber = roomNo;
        }

        public override void Enter()
        {
            Console.WriteLine($"You entered room number ${_roomNumber}.");
        }

        public MapSite GetSide(Direction direction) => _sides[(int)direction];

        public void SetSide(Direction direction, MapSite mapSite)
        {
            _sides[(int)direction] = mapSite;
        }

        #region Support the Prototype pattern.

        [SuppressMessage(
            "StyleCop.Analyzers",
            "SA1201:ElementsMustAppearInTheCorrectOrder",
            Justification = "Support the use of regions.")]
        public Room(Room other)
        {
            _roomNumber = other._roomNumber;
        }

        public virtual Room Clone()
        {
            return new Room(this);
        }

        public void Initialize(int n)
        {
            _roomNumber = n;
        }

        #endregion
    }
}
