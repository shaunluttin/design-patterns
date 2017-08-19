namespace CreationalPatterns.Models
{
    public class RoomWithABomb : Room
    {
        public RoomWithABomb(int roomNo) : base(roomNo)
        {
        }

        #region Support the Prototype pattern.

        public RoomWithABomb(RoomWithABomb other) : base(other)
        {
        }

        public override Room Clone()
        {
            return new RoomWithABomb(this);
        }

        #endregion
    }
}