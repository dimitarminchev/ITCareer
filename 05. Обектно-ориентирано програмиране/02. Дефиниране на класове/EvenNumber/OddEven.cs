namespace EvenNumber
{
    public interface IOddEven
    {
        bool IsOdd(int number);
        bool IsEven(int number);
    }

    public class OddEven : IOddEven
    {
        public bool IsOdd(int number)
        {
            return number % 2 != 0 ? true : false;
        }

        public bool IsEven(int number)
        {
            return number % 2 == 0 ? true : false;
        }
    }
}
