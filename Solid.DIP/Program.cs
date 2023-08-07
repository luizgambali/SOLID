/*
    DIP — Dependency Inversion Principle

    The Dependency Inversion Principle states that “high-level modules should not depend on low-level modules. Both should depend on abstractions.”
    
    This principle is about the decoupling of modules. When we follow this principle, it allows us to change the low-level modules easily without affecting 
    the high-level modules.

*/

using Solid.DIP.Correct;
using Solid.DIP.Wrong;

Console.WriteLine("DIP — Dependency Inversion Principle");

WrongWay.Test();
CorrectWay.Test();
