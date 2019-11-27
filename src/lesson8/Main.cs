using System;

namespace Concept.Method.Lesson8 {
    class Main {
        public void Run() {
            Params();
            Params(1);
            Params(1,3,5);
        }
        private void Params(params int[] args) {
            Console.WriteLine(String.Join(",", args));
        }
    }
}
