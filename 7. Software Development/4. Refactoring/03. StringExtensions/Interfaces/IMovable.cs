namespace YoloSnake.Interfaces
{
    using Enums;

    /// <summary>
    /// Интерфейс, който позволява местене
    /// </summary>
    public interface IMovable
    {
        /// <summary>
        /// Посоката на местенето
        /// </summary>
        Direction Direction { get; }

        /// <summary>
        /// Метод извършващ местенето
        /// </summary>
        void Move();

        /// <summary>
        /// Метод за смяна на посоката на местене
        /// </summary>
        /// <param name="newDirection">Нова посока за местене</param>
        void ChangeDirection(Direction newDirection);
    }
}