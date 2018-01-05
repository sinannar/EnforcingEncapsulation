using System;
using System.Collections.Generic;
using System.Text;

namespace EnforcingEncapsulation
{
    /*
        public      None; unrestricted access
        internal    Limited to the current assembly
        protected   Limited to the containing class and derived classes
        protected   internal Limited to the current assembly or derived types
        private     Limited to the containing type
     */
    class Dog
    {
        public void Bark() { }
    }
}
