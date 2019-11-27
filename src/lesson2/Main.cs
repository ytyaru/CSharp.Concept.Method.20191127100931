using System;

namespace Concept.Method.Lesson2 {
    class Main {
        public void Run() {
            A();
            int f = F();
            Console.WriteLine($"{f}");
            A(1);
            Console.WriteLine($"{F(2)}");
        }
        public void A() => Console.WriteLine("A");
        public int F() => 100;
        public void A(int p) => Console.WriteLine($"A: p={p}");
        public int F(int p) { Console.WriteLine($"F: p={p}"); return 101; }
    }
}
