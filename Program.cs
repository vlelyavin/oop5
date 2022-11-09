using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace oop.task5 {
    internal class Program {
        public static void Main(string[] args) {
            MyList<Int32> myList = new MyList<int>();
            myList.Add(71);
            myList.Add(323);
            myList.Add(959);
            myList.Add(1);
            myList.Add(1);
            myList.Add(1);
            myList.Add(128);
            myList.Add(1);
            myList.Add(1);
            myList.Add(1);
            myList.Add(1);
            myList.Add(7895);
            Console.WriteLine(myList.size());
            foreach (var item in myList.GetArray()) {
                Console.WriteLine(item);
            }
            MyDictionary<Int32, string> myDictionary = new MyDictionary<int, string>(10);
            MyDictionary.Put(1, 'a');
            MyDictionary.printDictionary();
        }
    }
}