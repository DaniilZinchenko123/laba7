namespace Task3
{
    public class CacheItem<TResult>
    {
        public TResult Result { get; }
        public DateTime Timestamp { get; }

        public CacheItem(TResult result, DateTime timestamp)
        {
            Result = result;
            Timestamp = timestamp;
        }
    }
}