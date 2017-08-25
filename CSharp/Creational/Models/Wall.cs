using System;

namespace CreationalPatterns.Models
{
    public class Wall : MapSite
    {
        public Wall() { }

        public override void Enter()
        {
            Console.WriteLine("You walked into a wall. Ouch!");
        }

        #region Support the Prototype pattern.

        public Wall(Wall other) { }

        public virtual Wall Clone()
        {
            return new Wall(this);
        }

        #endregion
    }
}