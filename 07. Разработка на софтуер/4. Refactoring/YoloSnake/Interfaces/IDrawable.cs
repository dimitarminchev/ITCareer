/// <summary>
/// Refactoring Task "Yolo Snake" Namespace.
/// </summary>
namespace YoloSnake.Interfaces
{
    /// <summary>
    /// Yolo Snake draw interface.
    /// </summary>
    public interface IDrawable
    {
        /// <summary>
        /// Yolo Snake draw metod.
        /// </summary>
        /// <param name="drawer"></param>
        void Draw(IDrawer drawer);
    }
}