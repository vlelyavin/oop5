using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using oop.vlelyavin.task5;

namespace Task3Oop.task5 {
    internal class MyDictionary<TKey, TValue> {
        private int cap = 10;
        private Entry<TKey, TValue>[] table;
        public MyDictionary(int cap) {
            this.cap = cap;
            this.table = new Entry<TKey, TValue>[cap];
        }
        public void Put(TKey newKey, TValue newValue) {
            if (newKey == null) return;
            int hash = Hash(newKey);
            Entry<TKey, TValue> newEntry = new Entry<TKey, TValue>(newKey, newValue);
            if (table[hash] == null) table[hash] = newEntry;            
            Entry<TKey, TValue> previous = null;
            Entry<TKey, TValue> current = table[hash];
            while (current != null) {
                if (current.GetKey().Equals(newKey)) {
                    if (previous == null) {
                        newEntry.SetNext(current.GetNext());
                        table[hash] = newEntry;
                        return;
                    }
                } else {
                    newEntry.SetNext(current.GetNext());
                    previous.SetNext(newEntry);
                }
                previous = current;
                current = (Entry<TKey, TValue>)current.GetNext();
            }
            previous.SetNext(newEntry);
        }

        public void printDictionary() {
            for (int i = 0; i < cap; i++) {
                if (table[i] != null) {
                    Entry<TKey, TValue> entry = table[i];
                    while (entry != null) {
                        Console.WriteLine('{' + entry.GetKey() + '=' + entry.GetValue() + '}' + ' ');
                        entry = (Entry<TKey, TValue>)entry.GetNext();
                    }
                }
            }
        }
        private int Hash(TKey key) {
            return Math.Abs(key.GetHashCode()) % cap;
        }
    }
}