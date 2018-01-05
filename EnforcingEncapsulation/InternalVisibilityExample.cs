using System;
using System.Collections.Generic;
using System.Text;

namespace EnforcingEncapsulation
{

    /*
        [assembly:InternalsVisibleTo("Friend1a")]
        [assembly:InternalsVisibleTo("Friend1b")]
        
            When you want to expose internal types or type members to another assembly, you can
        use a special attribute: InternalsVisibleToAttribute. You can use this attribute to specify another
        assembly that can also access the internal types. One situation where this can be useful is
        when you write unit tests. Maybe you have an internal class that encapsulates a difficult algorithm
        and you want to write unit tests for it. Normally, you include this attribute inside the
        AssemblyInfo.cs file that’s stored in the Properties folder of your project

        Members of          Default member accessibility            Allowed declared accessibility of the member
        ---------------------------------------------------------------------------------------------------------
        enum                public                                  None
        ---------------------------------------------------------------------------------------------------------
        class               private                                 public
                                                                    protected
                                                                    internal
                                                                    private
                                                                    protected internal
        ---------------------------------------------------------------------------------------------------------
        interface           public                                  None
        ---------------------------------------------------------------------------------------------------------
        struct              private                                 public
                                                                    internal
                                                                    private
        ---------------------------------------------------------------------------------------------------------

     */
    internal class MyInternalClass
    {
        public void MyMethod() { }
    }

    class FriendA { }
    class FriendB { }




    class InternalVisibilityExample
    {
    }

}
