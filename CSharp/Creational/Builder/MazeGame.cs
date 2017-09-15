using CreationalPatterns.Models;
using CreationalPatterns.Builder;

namespace CreationalPatterns.Builder
{
    public class MazeGame
    {
        /*
         * "Notice how the builder hides the internal representation of the
         * Maze... This makes it easier to change the way a maze represented,
         * since none of the clients of `MazeBuilder` has to be changed."
         * (Gamma et al)
         */
        public Maze CreateMaze(MazeBuilder builder)
        {
            builder.BuildMaze();
            builder.BuildRoom(1);
            builder.BuildRoom(2);
            builder.BuildDoor(1, 2);

            return builder.GetMaze();
        }

        /*
         * "We can reuse `MazeBuilder` to create different kinds of mazes.
         * The `CreateComplexMaze` operation gives an example."
         * (Gamma et al)
         */
        public Maze CreateComplexMaze(MazeBuilder builder)
        {
            builder.BuildRoom(1);
            // ...
            builder.BuildRoom(1001);

            return builder.GetMaze();
        }
    }
}
