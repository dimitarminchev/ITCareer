/// <summary>
/// Refactoring Task "Cohesion And Coupling" Namespace.
/// </summary>
namespace CohesionAndCoupling.Extensions
{
    /// <summary>
    /// Cohesion and coupling file extensions class.
    /// </summary>
    public static class FileExtesions
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
