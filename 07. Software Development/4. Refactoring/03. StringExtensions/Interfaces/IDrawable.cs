namespace YoloSnake.Interfaces
{
    /// <summary>
    /// Интерфейс за чертане!
    /// </summary>
    public interface IDrawable
    {
        /// <summary>
        ///  Метод за чертане!
        /// </summary>
        /// <param name="drawer">Интерфейс</param>
        void Draw(IDrawer drawer);
    }
}