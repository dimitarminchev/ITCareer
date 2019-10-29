using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_3
{
    public static class Swapper
    {
        public static List<Box<T>> Swap<T>(List<Box<T>> list, int index1, int index2)
        {
            T toSwap = list[index1].Item;
            list[index1].Item = list[index2].Item;
            list[index2].Item = toSwap;
            return list;
        }
    }
}
