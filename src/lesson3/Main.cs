using System;

namespace Concept.Method.Lesson3 {
    class Main {
        public void Run() {
            P(1, 2);       // P: p1=1, p2=2
            P(p2:2, p1:1); // P: p1=1, p2=2
            P(1, p2:2);    // P: p1=1, p2=2
            P(p1:1, 2);    // P: p1=1, p2=2
//            P(p2:2, 3);    // error CS8323
//            P();           // error CS7036

            N(1, 2);       // N: p1=1, p2=2
            N(p2:2, p1:1); // N: p1=1, p2=2
            N(1, p2:2);    // N: p1=1, p2=2
            N(p1:1, 2);    // N: p1=1, p2=2
//            N(p2:2, 3);    // error CS8323
            N();           // N: p1=0, p2=0
            N(1);          // N: p1=1, p2=0
            N(p1:1);       // N: p1=1, p2=0
            N(p2:2);       // N: p1=0, p2=2

//            O();           // error CS7036
            O(1);          // O: p1=1, o1=0
//            O(o1:2);       // error CS7036
            O(1, o1:2);    // O: p1=1, o1=2
            O(p1:1, o1:2); // O: p1=1, o1=2
            O(o1:2, p1:1); // O: p1=1, o1=2
        }
        public void P(int p1, int p2) => Console.WriteLine($"P: p1={p1}, p2={p2}");
        public void N(int p1=0, int p2=0) => Console.WriteLine($"N: p1={p1}, p2={p2}");
        public void O(int p1, int o1=0) => Console.WriteLine($"O: p1={p1}, o1={o1}");
//        public void O2(int o=0, int p) => Console.WriteLine($"O: p={p}, o={o}"); // error CS1737
    }
}
