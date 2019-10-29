namespace CryptoMiningSystem.Utilities
{
    public class Validation
    {
        public static bool CheckNullOrEmptyString(string value)
        {
            return string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value);
        }

        public static bool IsNumberNegativeOrZero(int value)
        {
            return value <= 0;
        }

        public static bool IsMoneyNegative(decimal value)
        {
            return value < 0;
        }

        public static bool IsGameGenerationValid(int value)
        {
            return value <= Constants.GameBiggestGenerationValue;
        }

        public static bool IsProcessorGenerationValid(int value)
        {
            return value <= Constants.ProcessorBiggestGenerationValue;
        }

        public static bool IsRamCapacityValid(int value)
        {
            return !IsNumberNegativeOrZero(value) && value <= Constants.MaxRam;
        }

        public static bool IsMineGenerationValid(int value)
        {
            return value <= Constants.MineBiggestGenerationValue;
        }

        public static bool IsComponentPriceValid(decimal price)
        {
            return 0 < price && price <= 10000;
        }
    }
}
