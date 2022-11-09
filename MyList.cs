using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace oop.task5 {
    internal class MyList<T> {
        private T[] baseArr;
        private int amountOfElements;
        private int index;
        public MyList() {
            this.baseArr = new T[10];
            this.index = -1;
        }
        public void Add(T element) {
            if (amountOfElements == 10) {
                amountOfElements = 0;
                T[] copyOfArray = new T[baseArr.Length];
                baseArr.CopyTo(copyOfArray, 0);
                baseArr = new T[baseArr.Length + 10];
                copyOfArray.CopyTo(baseArr, 0);
                baseArr[++index] = element;
                amountOfElements++;
            }
            baseArr[++index] = element;
            amountOfElements++;
        }
        public T FindByIndex(int index) {
            return baseArr[index];
        }
        public int size() {
            return index + 1;
        }
        public T[] GetArray() {
            return baseArr;
        }
    }
}