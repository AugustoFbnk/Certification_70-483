//------------------------------------------------------------------------------
using System.Collections;
using System.Collections.Generic;

namespace Certification70_483._04_ImplementDataAccess._05_StoreDataInAndRetrieveDataFromCollections
{

    /// <summary>
    /// Using the ISet<T> interface
    /// </summary>
    public class Example86
    {

        public static void Start()
        {
            var setInt = new SetInt();
        }

        public class SetInt : ISet<int>
        {
            public int Count => throw new System.NotImplementedException();

            public bool IsReadOnly => throw new System.NotImplementedException();

            public bool Add(int item)
            {
                throw new System.NotImplementedException();
            }

            public void Clear()
            {
                throw new System.NotImplementedException();
            }

            public bool Contains(int item)
            {
                throw new System.NotImplementedException();
            }

            public void CopyTo(int[] array, int arrayIndex)
            {
                throw new System.NotImplementedException();
            }

            public void ExceptWith(IEnumerable<int> other)
            {
                throw new System.NotImplementedException();
            }

            public IEnumerator<int> GetEnumerator()
            {
                throw new System.NotImplementedException();
            }

            public void IntersectWith(IEnumerable<int> other)
            {
                throw new System.NotImplementedException();
            }

            public bool IsProperSubsetOf(IEnumerable<int> other)
            {
                throw new System.NotImplementedException();
            }

            public bool IsProperSupersetOf(IEnumerable<int> other)
            {
                throw new System.NotImplementedException();
            }

            public bool IsSubsetOf(IEnumerable<int> other)
            {
                throw new System.NotImplementedException();
            }

            public bool IsSupersetOf(IEnumerable<int> other)
            {
                throw new System.NotImplementedException();
            }

            public bool Overlaps(IEnumerable<int> other)
            {
                throw new System.NotImplementedException();
            }

            public bool Remove(int item)
            {
                throw new System.NotImplementedException();
            }

            public bool SetEquals(IEnumerable<int> other)
            {
                throw new System.NotImplementedException();
            }

            public void SymmetricExceptWith(IEnumerable<int> other)
            {
                throw new System.NotImplementedException();
            }

            public void UnionWith(IEnumerable<int> other)
            {
                throw new System.NotImplementedException();
            }

            void ICollection<int>.Add(int item)
            {
                throw new System.NotImplementedException();
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                throw new System.NotImplementedException();
            }
        }

        public interface ISet<T> : ICollection<T>, IEnumerable<T>, IEnumerable
        {
            bool Add(T item);
            void ExceptWith(IEnumerable<T> other);
            void IntersectWith(IEnumerable<T> other);
            bool IsProperSubsetOf(IEnumerable<T> other);
            bool IsProperSupersetOf(IEnumerable<T> other);
            bool IsSubsetOf(IEnumerable<T> other);
            bool IsSupersetOf(IEnumerable<T> other);
            bool Overlaps(IEnumerable<T> other);
            bool SetEquals(IEnumerable<T> other);
            void SymmetricExceptWith(IEnumerable<T> other);
            void UnionWith(IEnumerable<T> other);
        }
    }
}
