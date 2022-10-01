/// <summary>
/// Интерфейс за превозните сртрдства
/// </summary>
public interface IVehicle
{ 
    /// <summary>
    /// Гориво
    /// </summary>
    double Fuel { get; }

    /// <summary>
    /// Литри на километър
    /// </summary>
    double LitersPerKm { get; }

    /// <summary>
    /// Разстояние
    /// </summary>
    double Distance { get; }

    /// <summary>
    /// Карай
    /// </summary>
    void Drive(double km);

    /// <summary>
    /// Презареди
    /// </summary>
    void Refuel(double litres);
}