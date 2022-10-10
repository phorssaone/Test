//POD on 10/10/2022 foo1.cs
using System;
using System.IO;
using System.Text;

namespace FooTests {
    public class Foo {
        private int ffoo=0;

        private void SetFoo(int value) {
            if (ffoo != value)
                ffoo=value;
        }

        public Foo() {
            ffoo += 1;
        }

        public void Add(int value=1) {
            ffoo+=value;
        }

        public override string ToString() {
            return "Foo is " + ffoo.ToString();
        }

        public int Value {
            get { return ffoo; }
            set { SetFoo(value); }
        }
    }  //FooTests

    //-------------------------------------------------------------------------------------------------

    
}  //ns FooTests