using System.Collections;

namespace ListyIterator
{
    public class ListyIterator<T> : IEnumerable<T>
    {
        private int index = 0;
        private List<T> list;

        public ListyIterator(params T[] listy)
        {
            this.Create(listy);
        }

        public void Create(params T[] listy)
        {
            this.list = new List<T>(listy);
        }

        public bool Move()
        {
            if (!HasNext()) return false;
            else
            {
                this.index = this.index + 1;
                return true;
            }
        }

        public string Print()
        {
            if (this.list.Count == 0)
            {
                throw new Exception("Invalid Operation");
            }
            return this.list[this.index].ToString();
        }

        public bool HasNext()
        {
            if (this.index + 1 > this.list.Count - 1) return false;
            else return true;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < this.Count(); i++)
            {
                yield return this.list[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public void PrintAll()
        {
            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
        }
    }
}