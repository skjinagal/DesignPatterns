# Command Pattern

- The Command Pattern encapsulates a request as an object, thereby letting you parameterize other objects with different requests, queue or log requests, and support undoable operations.

- a command object encapsulates a request by binding together a set of actions on a specific receiver. To achieve this, it packages the actions and the receiver into an object that exposes just one method, execute().

- The Meta Command Pattern allows you to create macros of commands so that you can execute multiple commands at once.

- The Command Pattern decouples an object making a request from the one that knows how to perform it.

- 