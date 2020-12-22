namespace Lab5Strategy.Sorting
{
    internal class Selection : SortStrategy
    {
        public Selection() => Title = "Selection Sort";

        public override string ToString() => Title;

        public override void Sort(int[] array)
        {
            for (var i = 0; i < array.Length - 1; i++)
            {
                var k = i;
                for (var j = i + 1; j < array.Length; j++)
                    if (array[k] > array[j])
                        k = j;
                if (k != i)
                {
                    var temp = array[k];
                    array[k] = array[i];
                    array[i] = temp;
                }
            }
        }
    }
}