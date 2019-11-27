using System;

namespace Concept.Method.Lesson9 {
    class Main {
        public void Run() {
            Console.WriteLine($"{A()}");
            Console.WriteLine($"{B()}");
            Console.WriteLine($"{C()}");
        }
        private int A() { return 1; }
        private int B() => 2;
        private (int,int) C() => (1,2);
    }
}
