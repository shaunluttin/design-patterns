using System;

namespace CreationalPatterns.Models
{
    /*
     * "The common abstract class for all the components of the maze." (Gamma et al, 1994)
     * TODO: Discuss the differences between abstract classes and interfaces.
     */
    public abstract class MapSite
    {
        public abstract void Enter();
    }
}
