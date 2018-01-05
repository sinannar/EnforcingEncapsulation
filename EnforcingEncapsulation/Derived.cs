using System;
using System.Collections.Generic;
using System.Text;

namespace EnforcingEncapsulation
{
    /*
    
        Protected restricts accessibility to member of the type and all classes that derive from it. It can be used on all members of a classes.
        Private member is not accessible from derived classes
        
    */

    public class Base
    {
        private int _privateField = 42;
        protected int _protectedField = 42;
        private void MyPrivateMethod() { }
        protected void MyProtectedMethod() { }
    }

    public class Derived : Base
    {
        public void MyDerivedMethod()
        {
            // _privateField = 41; // Not OK, this will generate a compile error
            _protectedField = 43; // OK, protected fields can be accessed
                                  // MyPrivateMethod(); // Not OK, this will generate a compile error
            MyProtectedMethod(); // OK, protected methods can be accessed
        }
    }
}
