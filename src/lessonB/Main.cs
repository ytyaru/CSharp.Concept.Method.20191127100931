using System;
using System.Threading.Tasks;

namespace Concept.Method.LessonB {
    class Main {
        public void Run() {
            M().Wait();
        }
        private async Task M() {
            await Task.Delay(2000);
            Console.WriteLine($"非同期メソッド！");
        }
    }
}
