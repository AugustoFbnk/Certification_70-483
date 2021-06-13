using System.Collections;
using System.Collections.Generic;

namespace Certification70_483._04_ImplementDataAccess._05_StoreDataInAndRetrieveDataFromCollections
{
    /// <summary>
    /// Using IList<T> and ICollection<T>
    /// </summary>
    public class Example83
    {

        public static void Start()
        {
            Collection<int> collection = new Collection<int>();
            List<int> list = new List<int>();
        }

        public class Collection<T> : ICollection<T>
        {
            public int Count => throw new System.NotImplementedException();

            public bool IsReadOnly => throw new System.NotImplementedException();

            public void Add(T item)
            {
                throw new System.NotImplementedException();
            }

            public void Clear()
            {
                throw new System.NotImplementedException();
            }

            public bool Contains(T item)
            {
                throw new System.NotImplementedException();
            }

            public void CopyTo(T[] array, int arrayIndex)
            {
                throw new System.NotImplementedException();
            }

            public IEnumerator<T> GetEnumerator()
            {
                throw new System.NotImplementedException();
            }

            public bool Remove(T item)
            {
                throw new System.NotImplementedException();
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                throw new System.NotImplementedException();
            }
        }

        public class List<T> : IList<T>
        {
            public T this[int index] { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

            public int Count => throw new System.NotImplementedException();

            public bool IsReadOnly => throw new System.NotImplementedException();

            public void Add(T item)
            {
                throw new System.NotImplementedException();
            }

            public void Clear()
            {
                throw new System.NotImplementedException();
            }

            public bool Contains(T item)
            {
                throw new System.NotImplementedException();
            }

            public void CopyTo(T[] array, int arrayIndex)
            {
                throw new System.NotImplementedException();
            }

            public IEnumerator<T> GetEnumerator()
            {
                throw new System.NotImplementedException();
            }

            public int IndexOf(T item)
            {
                throw new System.NotImplementedException();
            }

            public void Insert(int index, T item)
            {
                throw new System.NotImplementedException();
            }

            public bool Remove(T item)
            {
                throw new System.NotImplementedException();
            }

            public void RemoveAt(int index)
            {
                throw new System.NotImplementedException();
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                throw new System.NotImplementedException();
            }
        }

        public interface IList<T> : ICollection<T>, IEnumerable<T>, IEnumerable
        {
            T this[int index] { get; set; }
            int IndexOf(T item);
            void Insert(int index, T item);
            void RemoveAt(int index);
        }
        public interface ICollection<T> : IEnumerable<T>, IEnumerable
        {
            int Count { get; }
            bool IsReadOnly { get; }
            void Add(T item);
            void Clear();
            bool Contains(T item);
            void CopyTo(T[] array, int arrayIndex);
            bool Remove(T item);
        }
    }

}
