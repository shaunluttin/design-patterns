using System;
using System.Collections.Generic;
using System.Linq;

namespace CreationalPatterns.Models
{
    public class Maze
    {
        private List<Room> _rooms = new List<Room>();

        public Maze() { }

        public void AddRoom(Room room)
        {
            _rooms.Add(room);
        }

        public Room RoomNo(int roomNo)
        {
            // Subtract one from the roomNo, 
            // because the C# List is zero indexed, 
            // whereas the maze starts at room one.
            return (_rooms.Count < roomNo)
                ? null
                : _rooms[roomNo - 1];
        }

        #region Support the Prototype pattern.

        public Maze(Maze other)
        {
            _rooms = other._rooms;
        }

        public Maze Clone()
        {
            return new Maze(this);
        }

        #endregion
    }
}