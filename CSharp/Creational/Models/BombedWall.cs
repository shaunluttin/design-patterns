namespace Creational.Models
{
    public class BombedWall : Wall
    {
        public BombedWall()
        : base() { }

        #region Support the Prototype pattern.

        public BombedWall(BombedWall other)
        : base(other) { }

        /*
         * "Although BombedWall::Clone returns a Wall, its implementation
         * returns a pointer to a new instance of a subclass, that is,
         * a BombedWall. We define Clone like this in the base class to
         * ensure that clients that clone the prototype don't have to know
         * about their concrete subclasses. Clients should never have to
         * downcast the return value of Clone to the desired type."
         * (Gamma et al)
         */
        public override Wall Clone()
        {
            return new BombedWall(this);
        }

        #endregion
    }
}
