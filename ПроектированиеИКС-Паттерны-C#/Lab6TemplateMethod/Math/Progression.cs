using System;
using System.Collections.Generic;

namespace Lab6TemplateMethod.Math
{
    internal abstract class Progression
    {
        public readonly List<int> Sequence;

        public int First { get; set; }
        public int Last { get; set; }
        public int Delta { get; set; }
        public Progression(int first, int last, int delta)
        {
            First = first;
            Last = last;
            Delta = delta;

            Sequence = new List<int>();
        }

        public void TemplateMethod()
        {
            InitializeProgression(First, Last, Delta);
            Progress();
            Print(Sequence);
        }

        private void Print(List<int> progList)
        {
            Console.Write("Sequence: ");
            foreach (var item in progList) Console.Write(item + " ");
            Console.WriteLine();
        }

        private void InitializeProgression(int start, int finish, int delta)
        {
            First = start;
            Last = finish;
            Delta = delta;
        }

        public abstract void Progress();
    }
}