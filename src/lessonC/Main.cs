using System;
using System.Threading.Tasks;

namespace Concept.Method.LessonC {
    class Main {
        public void Run() {
            A();
            C();
        }
        private void A() => Console.WriteLine("A");
//        private void B() => { } // error CS1525,CS1002,CS1519
        private void C() { Console.WriteLine("C"); }
    }
}
