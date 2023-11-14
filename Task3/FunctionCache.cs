namespace Task3
{
    public class FunctionCache<TKey, TResult>
    {
        private Dictionary<TKey, CacheItem<TResult>> cache = new Dictionary<TKey, CacheItem<TResult>>();

        public delegate TResult FuncDelegate(TKey key);

        public TResult Execute(FuncDelegate func, TKey key, TimeSpan cacheDuration)
        {
            if (cache.TryGetValue(key, out var cacheItem) && IsCacheValid(cacheItem, cacheDuration))
            {
                return cacheItem.Result;
            }

            TResult result = func(key);
            cache[key] = new CacheItem<TResult>(result, DateTime.Now);

            return result;
        }

        private bool IsCacheValid(CacheItem<TResult> cacheItem, TimeSpan cacheDuration)
        {
            return DateTime.Now - cacheItem.Timestamp <= cacheDuration;
        }
    }
}