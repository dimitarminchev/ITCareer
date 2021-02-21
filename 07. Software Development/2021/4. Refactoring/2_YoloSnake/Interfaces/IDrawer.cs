namespace YoloSnake.Interfaces
{
    /// <summary>
    /// Интерфейс за рисуване на точка
    /// </summary>
    public interface IDrawer
    {
        void DrawPoint(int x, int y, char symbol);
    }
}