using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank
{
    public class MinIntHeap
    {
        int _capacity = 10;
        int _size = 0;
        int _backSize = 0;

        int[] _items;
        int[] _itemsBackup;


        public MinIntHeap()
        {
            _items = new int[_capacity];
            _itemsBackup = new int[_capacity];
        }

        public int[] Items
        {
            get
            {
                var ret = new int[_size];
                for (int i = 0; i < _size; i++)
                {
                    ret[i] = _items[i];
                }
                return ret;
            }
        }

        int GetLeftChildIndex(int parentIndex) => 2 * parentIndex + 1;
        int GetRightChildIndex(int parentIndex) => 2 * parentIndex + 2;
        int GetParentIndex(int childIndex) => (childIndex - 1) / 2;

        bool HasLeftChild(int index) => GetLeftChildIndex(index) < _size;
        bool HasRightChild(int index) => GetRightChildIndex(index) < _size;
        bool HasParent(int index) => GetParentIndex(index) >= 0;

        int LeftChild(int index) => _items[GetLeftChildIndex(index)];
        int RightChild(int index) => _items[GetRightChildIndex(index)];
        int Parent(int index) => _items[GetParentIndex(index)];

        public void Backup()
        {            
            _items.CopyTo(_itemsBackup, 0);
            _backSize = _size;
        }

        public void Restore()
        {
            _itemsBackup.CopyTo(_items, 0);
            _size = _backSize;

        }

        void Swap(int indexOne, int indexTwo)
        {
            int tmp = _items[indexOne];
            _items[indexOne] = _items[indexTwo];
            _items[indexTwo] = tmp;
        }

        void EnsureExtraCapacity()
        {
            if (_size == _capacity)
            {
                _capacity *= 2;
                Array.Resize(ref _items, _capacity);
                Array.Resize(ref _itemsBackup, _capacity);
            }
        }

        public int Peek
        {
            get
            {
                if (_size == 0) throw new Exception("IllegalStateException");
                return _items[0];
            }
        }

        public int Poll()
        {
            if (_size == 0) throw new Exception("IllegalStateException");
            int item = _items[0];
            _items[0] = _items[_size - 1];
            _size--;
            HeapifyDown();
            return item;
        }

        public void Add(int item)
        {
            EnsureExtraCapacity();
            _items[_size] = item;
            _size++;
            HeapifyUp();
        }

        private void HeapifyUp()
        {
            int index = _size - 1;
            while (HasParent(index) && Parent(index) > _items[index])
            {
                Swap(GetParentIndex(index), index);
                index = GetParentIndex(index);
            }
        }

        private void HeapifyDown()
        {
            int index = 0;
            while (HasLeftChild(index))
            {
                int smallerChildIndex = GetLeftChildIndex(index);
                if (HasRightChild(index) && RightChild(index) < LeftChild(index))
                {
                    smallerChildIndex = GetRightChildIndex(index);
                }

                if (_items[index] < _items[smallerChildIndex])
                {
                    break;
                }
                else
                {
                    Swap(index, smallerChildIndex);
                }
                index = smallerChildIndex;
            }
        }

        public int[] SortedArray()
        {
            var ret = new int[_size];
            var size = _size;
            Backup();
            for (int i = 0; i < size; i++)
            {
                ret[i] = Poll();
            }
            Restore();
            return ret;
        }
    }
}
