# Adaptor Pattern and Facade Pattern

- The Adapter Pattern converts the interface of a class into another interface the clients expect. Adapter lets
classes work together that couldn’t otherwise because of incompatible interfaces.

- The intent of the Adapter Pattern is to alter an interface so that it matches one a client is expecting. The intent of the Facade Pattern is to provide a simplified interface to a subsystem.

- The Facade Pattern provides a unified interface to a set of interfaces in a subsystem. Facade defines a higher-level interface that makes the subsystem easier to use.

- Principle of Least Knowledge: talk only to your immediate friends.

- The principle provides some guidelines: take any object, and from any method in that object, invoke only methods that belong to:

-  The object itself

- Objects passed in as a parameter to the method

- Any object the method creates or instantiates

- Any components of the object

```C#
public class Car {
    Engine engine;
    // other instance variables
    public Car() {
    // initialize engine, etc.
    }
    public void start(Key key) {
        Doors doors = new Doors();
        boolean authorized = key.turns();
        if (authorized) {
            engine.start();
            updateDashboardDisplay();
            doors.lock();
        }
    }
    public void updateDashboardDisplay() {
    // update display
    }
}
```

- An adapter wraps an object to change its interface, a decorator wraps an object to add new behaviors and responsibilities, and a facade
“wraps” a set of objects to simplify.
