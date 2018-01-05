using System;
using System.Collections.Generic;
using System.Text;

namespace EnforcingEncapsulation
{
    class CreatingProperty
    {
        private string _firstName;

        public string FirstName
        {
            get { return _firstName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException();
                _firstName = value;
            }
        }

        /*
        
        As you can see, the get and set methods are part of the property definition. The field that
        contains the real data is private and can be accessed only through the property (except when
        inside the class).
        Using a property with the default get and set methods is so common that C# added a
        shorthand notation for it:
         */
        public int Value { get; set; } // shorthand notation
    }
}
