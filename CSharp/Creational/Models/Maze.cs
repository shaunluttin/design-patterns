using System;
using System.Collections.Generic;
using System.Linq;

namespace CreationalPatterns.Models
{
    public class Maze
    {
        private List<Room> _rooms = new List<Room>();

        public void AddRoom(Room room)
        {
            _rooms.Add(room);
        }

        public Room RoomNo(int roomNo)
        {
            // Subtract one from the roomNo, 
            // because the C# List is zero indexed, 
            // whereas the maze starts in room numbers at one.
            if (_rooms.Count < roomNo)
            {
                return null;
            }

            return _rooms[roomNo - 1];
        }
    }
}