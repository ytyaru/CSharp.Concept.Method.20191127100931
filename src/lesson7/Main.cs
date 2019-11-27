using System;

namespace Concept.Method.Lesson7 {
    class Main {
        public void Run() {
            int i = 1;
            PassValueR(ref i);
            Console.WriteLine($"i={i}");

            int k;
//            PassValueR(out k); // error CS1620
            PassValueO(out k);
            Console.WriteLine($"k={k}");

            PassValueI(in i);
        }
        private void PassValueR(ref int v) { v = 2; }
        private void PassValueO(out int v) { v = 2; }
//        private void PassValueO(out int v) { } // error CS0177
        private void PassValueI(in  int v) { Console.WriteLine($"in v={v}"); }
//        private void PassValueI(in  int v) { v = 2; } // error CS8331
    }
}
