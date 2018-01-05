using System;
using System.Collections.Generic;
using System.Text;

namespace EnforcingEncapsulation
{
    class ExplicitInterfaceImplementations
    {
    }


    /*
        Interfaces are useful when using encapsulation. In the next objective, you look at how you
        can design and use interfaces. But regarding the topic of encapsulation, you need to know
        about explicit interface implementation.
     */
    interface IInterfaceA
    {
        void MyMethod();
    }
    class Implementation : IInterfaceA
    {
        void IInterfaceA.MyMethod() { }
    }
    /*
        The Implementation class implements the interface IInterfaceA explicitly. When you have
        an instance of Implementation, you can’t access MyMethod. But when you cast Implementation
        to IInterfaceA, you have access to MyMethod. In such a way, explicit interface implementation
        can be used to hide members of a class to outside users.

        There is another situation in which explicit interface implementation is necessary: when a
        class implements two interfaces that contain duplicate method signatures but wants a different
        implementation for both. When implicitly implementing those two interfaces, only one
        method exists in the implementation. With explicit interface implementation, both interfaces
        have their own implementation

        */

    interface ILeft
    {
        void Move();
    }

    interface IRight
    {
        void Move();
    }

    class MoveableOject : ILeft, IRight
    {
        void ILeft.Move() { }
        void IRight.Move() { }
    }
}
