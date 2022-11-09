using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using oop.vlelyavin.task5;

namespace oop.task5 {
    internal class Entry<TKey, TValue> {
        private TKey key;
        private TValue value;
        private Pair<TKey, TValue> next;
        public Entry(TKey key, TValue value) {
            this.key = key;
            this.value = value;
        }
        public TKey GetKey() {
            return key;
        }
        public void SetKey(TKey value) {
            key = value;
        }
        public TValue GetValue() {
            return value;
        }
        public void SetValue(TValue value) {
            this.value = value;
        }
        public Pair<TKey, TValue> GetNext() {
            return next;
        }
        public void SetNext(Pair<TKey, TValue> value) {
            next = value;
        }
        public static implicit operator Pair<TKey, TValue>(Entry<TKey, TValue> v) {
            throw new Exception();
        }
        public static explicit operator Entry<TKey, TValue>(Pair<TKey, TValue> v) {
            throw new Exception();
        }
    }
}