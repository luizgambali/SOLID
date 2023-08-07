/*
    LSP: Liskov Substitution Principle

    The Liskov Substitution Principle states that “objects in a program should be replaceable with instances of their subtypes without altering the correctness of that program.”

    In other words, as long as each class implements the same behaviors as the base class, the program should behave correctly.
*/

using Solid.LSP.Correct;
using Solid.LSP.Wrong;

Console.WriteLine("LSP: Liskov Substitution Principle");

WrongWay.Test();
CorrectWay.Test();
