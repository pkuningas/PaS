using System.Collections;
using System.Collections.Generic;

namespace Logic
{
    public class Archetypes<T>: Archetype, IList<T>
    {
        public readonly List<T> List = new List<T>();

        public int Count => List.Count;

        public bool IsReadOnly { get; set; }

        public T this[int index]
        {
            get { return List[index]; }
            set
            {
                if (IsReadOnly)
                {
                    return;
                }
                List[index] = value;
                DoOnChanged();
            }
        }

        public int IndexOf(T item)
        {
            return List.IndexOf(item);
        }

        public void Insert(int index, T item)
        {
            if (IsReadOnly) return;
            List.Insert(index, item);
            DoOnChanged();
        }

        public void RemoveAt(int index)
        {
            if (IsReadOnly) return;
            List.RemoveAt(index);
            DoOnChanged();
        }

        public void Add(T item)
        {
            if (IsReadOnly) return;
            List.Add(item);
            DoOnChanged();
        }

        public void Clear()
        {
            if (IsReadOnly) return;
            List.Clear();
        }

        public bool Contains(T item)
        {
            return List.Contains(item);
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            List.CopyTo(array, arrayIndex);
        }

        public bool Remove(T item)
        {
            if (IsReadOnly) return false;
            var remove = List.Remove(item);
            if (remove) DoOnChanged();
            return remove;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return List.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
