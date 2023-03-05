/// <summary>
/// Refactoring Task "Cohesion and Coupling.Extensions" namespace.
/// </summary>
namespace Cohesion_and_Coupling.Extensions
{
    /// <summary>
    /// Refactoring Task "Cohesion and Coupling" class Extensions.FilesExtension.
    /// </summary>
    public static class FilesExtension
    {
        /// <summary>
        /// Cohesion and coupling file extensions get file extension method.
        /// </summary>
        /// <param name="fileName">Filename</param>
        /// <returns>Entension</returns>
        public static string GetFileExtension(string fileName)
        {
            int indexOfLastDot = fileName.LastIndexOf(".");
            if (indexOfLastDot == -1)
            {
                return "";
            }

            string extension = fileName.Substring(indexOfLastDot + 1);
            return extension;
        }

        /// <summary>
        /// Cohesion and coupling file extensions get filename without the extension method.
        /// </summary>
        /// <param name="fileName">Filename</param>
        /// <returns>Entension</returns>
        public static string GetFileNameWithoutExtension(string fileName)
        {
            int indexOfLastDot = fileName.LastIndexOf(".");
            if (indexOfLastDot == -1)
            {
                return fileName;
            }

            string extension = fileName.Substring(0, indexOfLastDot);
            return extension;
        }
    }
}
