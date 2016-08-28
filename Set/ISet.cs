using System.Collections.Generic;

namespace Set
{
    public interface ISet<T> : IEnumerable<T>
    {
        int Count { get; }
        void Add(T item);
        ISet<T> Copy();
        bool Contains(T item);
        ISet<T> UnionWith(ISet<T> other);
        ISet<T> IntersectionWith(ISet<T> other);
        bool EqualTo(ISet<T> other);
        void Remove(T item);
    }
}
