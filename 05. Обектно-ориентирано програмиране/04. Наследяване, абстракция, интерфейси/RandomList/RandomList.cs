using System.Collections;

namespace RandomList
{
    public class RandomList : ArrayList
    {
        private Random random = new Random();

        public object RandomObject()
        {
            var index = random.Next(0, base.Count - 1);
            object element = base[index];
            base.Remove(element);
            return element;
        }
    }
}
