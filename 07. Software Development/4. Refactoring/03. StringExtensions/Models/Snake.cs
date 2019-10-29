namespace YoloSnake.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Enums;
    using Interfaces;

    public class Snake : IPlayable
    {
        private const Direction StartDirection = Direction.Right;

        private LinkedList<IPosition> positions;
        private readonly char symbol;

        public Snake(char symbol, int startX, int startY, int initialLength)
        {
            this.symbol = symbol;
            this.InitializeSnakeBody(startX, startY, initialLength);
            this.Direction = StartDirection;
        }

        public IPosition Head
        {
            get
            {
                return this.positions.First.Value;
            }
        }

        public Direction Direction
        {
            get;
            private set;
        }

        public void Eat(IPosition position)
        {
            this.positions.AddLast(position);
        }

        public void ChangeDirection(Direction newDirection)
        {
            switch (newDirection)
            {
                case Direction.Up:
                    if (this.Direction != Direction.Down)
                    {
                        this.Direction = newDirection;
                    }
                    break;
                case Direction.Down:
                    if (this.Direction != Direction.Up)
                    {
                        this.Direction = newDirection;
                    }
                    break;
                case Direction.Left:
                    if (this.Direction != Direction.Right)
                    {
                        this.Direction = newDirection;
                    }
                    break;
                case Direction.Right:
                    if (this.Direction != Direction.Left)
                    {
                        this.Direction = newDirection;
                    }
                    break;
                default:
                    throw new ArgumentException("Unknown direction");
            }
        }

        public void Move()
        {
            this.positions.RemoveLast();

            var head = this.positions.First();
            switch (this.Direction)
            {
                case Direction.Up:
                    this.positions.AddFirst(new Position(head.X, head.Y - 1));
                    break;
                case Direction.Down:
                    this.positions.AddFirst(new Position(head.X, head.Y + 1));
                    break;
                case Direction.Left:
                    this.positions.AddFirst(new Position(head.X - 1, head.Y));
                    break;
                case Direction.Right:
                    this.positions.AddFirst(new Position(head.X + 1, head.Y));
                    break;
                default:
                    throw new ArgumentException("Unknown direction");
            }
        }

        public void Draw(IDrawer drawer)
        {
            foreach (var position in this.positions)
            {
                drawer.DrawPoint(position.X, position.Y, this.symbol);
            }

            var last = this.positions.Last;

            drawer.DrawPoint(last.Value.X, last.Value.Y, ' ');
        }

        private void InitializeSnakeBody(int startX, int startY, int initialLength)
        {
            this.positions = new LinkedList<IPosition>();

            for (int i = 0; i <= initialLength; i++)
            {
                this.positions.AddLast(new Position(i + startX, startY));
            }
        }
    }
}