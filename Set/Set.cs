using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using DeepEqual.Syntax;

namespace Set
{
    public class Set<T> : ISet<T>
    {
        private List<T> set;
        public int Count => set.Count;

        public Set()
        {
            set = new List<T>();
        }

        public T this[int index]
        {
            get { return set[index]; }
            set { set[index] = value; }
        }

        public void Add(T item)
        {
            if (!Contains(item))
            {
                set.Add(item);
            }
        }

        public void Add(IEnumerable<T> items)
        {
            foreach (T item in items)
            {
                Add(item);
            }
        }

        public void Add(IEnumerable<T> items, Func<T, bool> filter)
        {
            foreach (T item in items)
            {
                if (filter(item))
                {
                    Add(item);
                }
            }
        }

        public void Remove(T item)
        {
            set.Remove(item);
        }

        public ISet<T> Copy()
        {
            ISet<T> copy = new Set<T>();

            foreach (T item in set)
            {
                copy.Add(item);
            }

            return copy;
        }

        public bool Contains(T item)
        {
            // Do a deep equality check if T is enumerable
            if (item is IEnumerable)
            {
                return set.Any(i => item.IsDeepEqual(i));
            }

            return Enumerable.Contains(set, item);
        }

        public ISet<T> UnionWith(ISet<T> other)
        {
            ISet<T> union = Copy();

            foreach (T item in other)
            {
                if (!union.Contains(item))
                {
                    union.Add(item);
                }
            }

            return union;
        }

        public ISet<T> IntersectionWith(ISet<T> other)
        {
            ISet<T> intersection = new Set<T>();

            foreach (T item in other)
            {
                if (set.Contains(item))
                {
                    intersection.Add(item);
                }
            }

            return intersection;
        }

        public bool EqualTo(ISet<T> other)
        {
            if (set.Count != other.Count)
            {
                return false;
            }

            foreach (T item in other)
            {
                if (!set.Contains(item))
                {
                    return false;
                }
            }

            return true;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return ((IEnumerable<T>) set).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public T[] ToArray()
        {
            return set.ToArray();
        }

        public List<T> ToList()
        {
            return set;
        }

        public override string ToString()
        {
            return $"{{ {string.Join(", ", set)} }}";
        }
    }
}
