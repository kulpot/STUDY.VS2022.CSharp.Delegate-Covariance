using System;

//ref link:https://www.youtube.com/watch?v=JV_v3dLLNug&list=PLAE7FECFFFCBE1A54&index=23
// Delegate Covariance 

class Base { }
class Derived : Base { }
class Derived2 : Base { }

delegate Base ReturnsBaseDelegate();// can return none specific
delegate Derived ReturnsDerivedDelegate(); // always returns specific 

class MainClass
{
    //static Base ReturnsBase() { return null; }
    //static Base ReturnsBase() { return new Base(); }
    static Base ReturnsBase() { return new Derived2(); } // specific
    //static Derived ReturnsDerived() { return null; } 
    //static Derived ReturnsDerived() { return new Base(); } // None specific error
    static Derived ReturnsDerived() { return new Derived(); } // specific
    static void Main()
    {
        //ReturnsBaseDelegate b;
        ReturnsDerivedDelegate b;
        b = ReturnsBase; 
        b = ReturnsDerived;
    }
}