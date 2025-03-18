namespace blazortest.Models
{
    public class CounterModel
    {
        public int Count { get; set; }
        public event Action? OnCountChanged;

        public void IncrementCount()
        {
            Count++;
            OnCountChanged?.Invoke();
        }
    }
}
