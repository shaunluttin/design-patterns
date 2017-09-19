using System;
using System.Diagnostics.CodeAnalysis;

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

        [SuppressMessage(
            "StyleCop.Analyzers",
            "SA1201:ElementsMustAppearInTheCorrectOrder",
            Justification = "Support the use of regions.")]
        public Wall(Wall other) { }

        public virtual Wall Clone()
        {
            return new Wall(this);
        }

        #endregion
    }
}
