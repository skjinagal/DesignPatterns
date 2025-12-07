# Project Title

Strategy Pattern

## Usage

this project is created to learn and understand Strategy Design pattern.
 - I have a duck super class which has some behaviors and the sub types inherits this super class to inherit those and behaviors and also override them
 - this is well and good but what happens if tomorrow, some new requirement comes, lets we want a fly behavior. 
 - what if declare interface for flying and quacking behavior and respective class can implement them whoeven wants this behavior, but this also using problem, becuase if some new duch comes then same implementation will have to be provided to all the duck.
 - If FlyBehavior and QuackBehavior are separated out into its interfacea and class, and compose Duck class using this then client can use any flybehavior as they want and may be even change the behavior at run.

The Strategy Pattern defines a family of algorithms, 
encapsulates each one, and makes them interchangeable. 
Strategy lets the algorithm vary independently from 
clients that use it.
Favour composition over inheritance
## License

License information.