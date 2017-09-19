using CreationalPatterns.Models;

namespace CreationalPatterns.Builder
{
    public class StandardMazeBuilder : MazeBuilder
    {
        private Maze _currentMaze;

        public override void BuildMaze()
        {
            _currentMaze = new Maze();
        }

        public override void BuildRoom(int roomNo)
        {
            if (_currentMaze.RoomNo(roomNo) == null)
            {
                var room = new Room(roomNo);
                _currentMaze.AddRoom(room);
                room.SetSide(Direction.North, new Wall());
                room.SetSide(Direction.South, new Wall());
                room.SetSide(Direction.East, new Wall());
                room.SetSide(Direction.West, new Wall());
            }
        }

        public override void BuildDoor(int roomFrom, int roomTo)
        {
            var r1 = _currentMaze.RoomNo(roomFrom);
            var r2 = _currentMaze.RoomNo(roomTo);
            var d = new Door(r1, r2);

            r1.SetSide(CommonWall(r1, r2), d);
            r2.SetSide(CommonWall(r1, r2), d);
        }

        public override Maze GetMaze()
        {
            return _currentMaze;
        }

        // "... determines the direction of the common wall between two rooms"
        // (Gamma et al)
        private Direction CommonWall(Room room1, Room room2)
        {
            // for the sake of this demo, return North every time.
            return Direction.North;
        }
    }
}
