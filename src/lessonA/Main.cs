using System;

namespace Concept.Method.LessonA {
    class Main {
        public void Run() {
            string s = "Hello Extension Methods";  
            Console.WriteLine($"{s.WordCount()}");
        }
    }
    public static class MyExtensions
    {
        public static int WordCount(this String str)
        {
            return str.Split(new char[] { ' ', '.', '?' }, 
                             StringSplitOptions.RemoveEmptyEntries).Length;
        }
    }   
}
