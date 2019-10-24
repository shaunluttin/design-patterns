using CreationalPatterns.Models;

namespace CreationalPatterns.Builder
{
    // "This builder doesn't create a maze at all; it just counts different
    // kinds of components that would have been created." (Gamma et al, 1994)
    public class CountingMazeBuilder : MazeBuilder
    {
        private int _doors = 0;

        private int _rooms = 0;

        public override void BuildRoom(int room)
        {
            _rooms++;
        }

        public override void BuildDoor(int room1, int room2)
        {
            _doors++;
        }

        public Counts GetCounts()
        {
            return new Counts
            {
                Doors = _doors,
                Rooms = _rooms
            };
        }

        public class Counts
        {
            public int Doors { get; set; }

            public int Rooms { get; set; }
        }
    }
}
