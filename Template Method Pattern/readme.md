# Template Method Pattern

- The Template Method defines the steps of an algorithm and allows subclasses to provide the implementation for one or more steps.

- The Template Method Pattern defines the skeleton of an algorithm in a method, deferring some steps to subclasses. Template Method lets subclasses redefine certain steps of an algorithm without changing the algorithm’s structure.

- Hollywood Principle, we allow low-level components to hook themselves into a system, but the high-level components determine when they are needed, and how. In
other words, the high-level components give the low-level components the “don’t call us, we’ll call you” treatment.

- Hooks are methods that do nothing or default behavior in the abstract class, but may be overridden in the subclass.

- The Strategy and Template Method Patterns both encapsulate algorithms, the first by composition and the other by inheritance.

- Factory Method is a specialization of Template Method.
