using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
    public class GenericList<T> : IEnumerable<T>
        where T : IComparable
    {
        private T[] array;
        private int index;

        public GenericList()
        {
            this.index = 0;
            this.array = new T[2];
        }

        public T this[int index]
        {
            get { return this.GetElementAtPosition(index); }
            set { this.SetElementAtPosition(index, value); }
        }

        public int Count
        {
            get { return this.array.Length; }
        }

        public event Action OnAddEvent;

        public event Action<int> OnResizeEvent;

        public T GetElementAtPosition(int index)
        {
            CheckArrayIndexValid(index);
            return this.array[index];
        }

        public void SetElementAtPosition(int index, T value)
        {
            CheckArrayIndexValid(index);
            this.array[index] = value;
        }

        public bool Remove(T element)
        {
            bool isRemoved = false;
            for (int i = 0; i < this.array.Length; i++)
            {
                if (isRemoved)
                {
                    T temp = this.array[i];
                    this.array[i] = this.array[i - 1];
                    this.array[i - 1] = temp;
                }
                else if (this.array[i].CompareTo(element)== 0)
                {
                    isRemoved = true;
                    this.index--;
                    this.array[i] = default(T);
                }
            }

            return isRemoved;
        }

        public void Add(T element)
        {
            this.array[index] = element;
            index++;
            if (index >= this.array.Length)
            {
                this.Resize();
            }

            this.OnAddEvent?.Invoke();
        }

        private void Resize()
        {
            T[] newArray = new T[this.array.Length * 2];
            for (int i = 0; i < this.array.Length; i++)
            {
                newArray[i] = this.array[i];
            }

            this.array = newArray;

            if (this.OnResizeEvent != null)
            {
                this.OnResizeEvent(this.array.Length);
            }
        }

        private void CheckArrayIndexValid(int index)
        {
            if (index >= this.index || index < 0)
            {
                throw new IndexOutOfRangeException();
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < this.index; i++)
            {
                yield return this.array[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public int CompareTo(T other)
        {
            throw new NotImplementedException();
        }
    }
}
