/// <summary>
/// Refactoring Task "Minesweeper" namespace.
/// </summary>
namespace Minesweeper
{
    /// <summary>
    /// Refactoring Task "Minesweeper" class "Ratings".
    /// </summary>
    public class Ratings
    {
        private string name;

        /// <summary>
        /// Player name
        /// </summary>
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        private int points;

        /// <summary>
        /// Player points
        /// </summary>
        public int Points
        {
            get
            {
                return points;
            }

            set
            {
                points = value;
            }
        }

        /// <summary>
        /// Ratings Class Overloaded Constructor
        /// </summary>
        /// <param name="name">Player name</param>
        /// <param name="points">Player points</param>
        public Ratings(string name, int points)
        {
            this.name = name;
            this.points = points;
        }

        /// <summary>
        /// Ratings Class Default Constructor
        /// </summary>
        public Ratings() : this(string.Empty, 0)
        {
            // empty
        }
    }
}
