using System;

namespace Concept.Method.Lesson5 {
    class Main {
        class C {
            public override bool Equals(object obj) {
                Console.WriteLine("比較した");
                return base.Equals(obj);
            }
        }
        public void Run() {
            var c = new C();
            c.Equals(c);
        }
    }
}
