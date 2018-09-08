using System;
using System.Collections.Generic;

namespace _714 {
    static class Enumerable {
        public static IEnumerable<int> Predicate(int value1, int value2, Predicate<int> predicate) {
            for(int i = value1; i <= value2; i++)
                if(predicate.Invoke(i))
                    yield return i;
        }
    }
}
