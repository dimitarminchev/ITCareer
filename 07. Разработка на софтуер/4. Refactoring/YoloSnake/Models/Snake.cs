using YoloSnake.Enums;
using YoloSnake.Interfaces;

/// <summary>
/// Refactoring Task "Yolo Snake" Namespace.
/// </summary>
namespace YoloSnake.Models
{
    /// <summary>
    /// Yolo Snake Class
    /// </summary>
    public class Snake : IPlayable
    {
        private const Direction StartDirection = Direction.Right;
        private LinkedList<IPosition> positions;
        private readonly char symbol;

        /// <summary>
        /// Yolo Snake class constructor.
        /// </summary>
        /// <param name="symbol">Character</param>
        /// <param name="startX">Start X coordinate position</param>
        /// <param name="startY">Start Y coordinate position</param>
        /// <param name="initialLength">Initial Lenght of the snake</param>
        public Snake(char symbol, int startX, int startY, int initialLength)
        {
            this.symbol = symbol;
            this.InitializeSnakeBody(startX, startY, initialLength);
            this.Direction = StartDirection;
        }

        /// <summary>
        /// Yolo Snake Head
        /// </summary>
        public IPosition Head { get { return positions.First.Value; } }

        /// <summary>
        /// Yolo Snake Direction
        /// </summary>
        public Direction Direction { get; private set; }

        /// <summary>
        /// Yolo Snake Eat method.
        /// </summary>
        /// <param name="position"></param>
        public void Eat(IPosition position)
        {
            positions.AddLast(position);
        }

        /// <summary>
        /// Yolo Snake change direction method.
        /// </summary>
        /// <param name="newDirection"></param>
        public void ChangeDirection(Direction newDirection)
        {
            switch (newDirection)
            {
                case Direction.Up:
                    if (this.Direction != Direction.Down) this.Direction = newDirection;
                    break;
                case Direction.Down:
                    if (this.Direction != Direction.Up) { this.Direction = newDirection; }
                    break;
                case Direction.Left:
                    if (this.Direction != Direction.Right) { this.Direction = newDirection; }
                    break;
                case Direction.Right:
                    if (this.Direction != Direction.Left)
                        this.Direction = newDirection;
                    break;
                default:
                    throw new ArgumentException("Unknown direction");
            }

        }

        /// <summary>
        /// Yolo Snake Move method
        /// </summary>
        public void Move()
        {
            positions.RemoveLast();

            var head = positions.First();

            switch (Direction)
            {
                case Direction.Up:
                    positions.AddFirst(new Position(head.X, head.Y - 1));
                    break;
                case Direction.Down:
                    positions.AddFirst(new Position(head.X, head.Y + 1));
                    break;
                case Direction.Left:
                    positions.AddFirst(new Position(head.X - 1, head.Y));
                    break;
                case Direction.Right:
                    positions.AddFirst(new Position(head.X + 1, head.Y));
                    break;
                default:
                    throw new ArgumentException("Unknown direction");
            }
        }


        /// <summary>
        /// Yolo Snake draw method.
        /// </summary>
        /// <param name="drawer">Drawer parameter</param>
        public void Draw(IDrawer drawer)
        {
            foreach (var position in this.positions)
            {
                drawer.DrawPoint(position.X, position.Y, this.symbol);
            }

            var last = this.positions.Last;

            drawer.DrawPoint(last.Value.X, last.Value.Y, ' ');
        }

        /// <summary>
        /// Yolo Snake initialize snake body.
        /// </summary>
        /// <param name="startX">Start X coordinate</param>
        /// <param name="startY">Start Y coordinate</param>
        /// <param name="initialLength">Initial snake lenght</param>

        private void InitializeSnakeBody(int startX, int startY, int initialLength)
        {
            positions = new LinkedList<IPosition>();

            for (int i = 0; i <= initialLength; i++)
                positions.AddLast(new Position(i + startX, startY));
        }
    }
}