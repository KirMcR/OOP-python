namespace Lab5Strategy.Sorting
{
    internal abstract class SortStrategy
    {
        public string Title { get; set; }
        public abstract void Sort(int[] array);
    }
}