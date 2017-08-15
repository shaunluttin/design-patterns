using System;

namespace CreationalPatterns
{
    public class Room : MapSite
    {
        public override void Enter()
        {
            Console.WriteLine($"You entered room number ${_roomNumber}.");
        }

        public MapSite GetSide(Direction direction) => _sides[(int)direction];

        public void SetSide(Direction direction, MapSite mapSite)
        {
            _sides[(int)direction] = mapSite;
        }

        public Room(short roomNo)
        {
            _roomNumber = roomNo;
        }

        private MapSite[] _sides = new MapSite[4];

        private short _roomNumber;
    }
}