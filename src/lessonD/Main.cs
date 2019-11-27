using System;
using System.Collections.Generic;

namespace Concept.Method.LessonD {
    class Main {
        public void Run() {
            foreach (int i in A()) {
                Console.WriteLine($"i={i}");
            }
        }
        private IEnumerable<int> A() {
            yield return 1;
            yield return 3;
            yield return 5;
        }
    }
}
