/*
    SRP: Single Responsibility Principle

    A class should have only one reason to change.

    In the 'Wrong' folder, the Person class has multiple responsibilities. It is responsible for representing a person, validating email addresses, 
    and saving to a database. This violates the SRP because the class has multiple reasons to change. If the database schema changes, the Person 
    class will need to change. If the email validation logic changes, the Person class will need to change. If the Person class needs to be 
    represented differently, the Person class will need to change.

    In the 'Correct' folder, the Person class has only one responsibility, which is to represent a person. Email validation
    and database persistence are now the responsibility of other classes. This adheres to the SRP because the Person class has only one reason to 
    change. If the database schema changes, the Person class will not need to change. If the email validation logic changes, the Person class will
    not need to change. If the Person class needs to be represented differently, the Person class will need to change.
*/

using Solid.SRP.Correct;
using Solid.SRP.Wrong;

Console.WriteLine("SRP: Single Responsibility Principle");

WrongWay.Test();
CorrectWay.Test();


