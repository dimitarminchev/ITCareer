using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _613
{
    public class ListyIterator<T> 
    {
        private int index = 0;
        private List<T> listy;

        public ListyIterator(params T[] listy)
        {
            this.Create(listy);
        }

        public void Create(params T[] listy)
        {
            this.listy = new List<T>(listy);
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
            if (this.listy.Count == 0)
            {
                throw new Exception("Invalid Operation");
            }
            return this.listy[this.index].ToString();
        }

        public bool HasNext()
        {
            if (this.index + 1 > this.listy.Count - 1) return false;
            else  return true;
        }
    }
}
