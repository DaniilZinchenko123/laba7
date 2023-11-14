using System.Linq;

namespace Task2
{
    public class Repository<T>
    {
        public delegate bool Criteria<T>(T item);

        private List<T> elements = new List<T>();

        public void Add(T item)
        {
            elements.Add(item);
        }

        public IEnumerable<T> Find(Criteria<T> criteria)
        {
            foreach (T item in elements)
            {
                if (criteria(item))
                {
                    yield return item;
                }
            }
        }
    }
}