using System;

namespace CreationalPatterns.Models
{
    public class Wall : MapSite
    {
        public override void Enter()
        {
            Console.WriteLine("You walked into a wall. Ouch!");
        }
    }
}