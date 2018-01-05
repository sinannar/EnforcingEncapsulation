using System;
using System.Collections.Generic;
using System.Text;

namespace EnforcingEncapsulation
{
    /*
        
        Hiding with private



    */
    class Accessibility
    {
        private string _myField;
        public string MyProperty
        {
            get { return _myField; }
            set { _myField = value; }
        }

        // initialization code and error checking omitted
        private string[] _myField2;
        public string MyProperty2
        {
            get { return _myField2[0]; }
            set { _myField2[0] = value; }
        }
    }
}
