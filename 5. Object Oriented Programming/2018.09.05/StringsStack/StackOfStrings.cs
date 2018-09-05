using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsStack
{
    public class StackOfStrings
    {
        private List<string> data = new List<string>();

        public void Push(string item)
        {
            data.Add(item);
        }

        public string Pop()
        {
            var last = data.Last();
            data.Remove(last);
            return last;
        }

        public string Peek()
        {
            return data.Last();
        }

        public bool IsEmpty()
        {
            return data.Count == 0 ? true : false;
        }

    }
}
