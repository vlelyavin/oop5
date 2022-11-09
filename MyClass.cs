using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace oop.task5 {
    internal class MyClass<T> {
        public static T factoryMethod(T t) {
            return t;
        }
    }
}