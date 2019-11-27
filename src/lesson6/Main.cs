using System;

namespace Concept.Method.Lesson6 {
    class Main {
        public void Run() {
            int i = 1;
            PassValue(i);
            Console.WriteLine($"i={i}");

            int[] a = new int[1] { 1 };
            PassReference(a);
            Console.WriteLine($"a[0]={a[0]}");
        }
        private void PassValue(int v) { v = 2; }
        private void PassReference(int[] r) { r[0] = 2; }
    }
}
