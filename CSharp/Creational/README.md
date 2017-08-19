## Advantaged of Creational Patterns

* "Creational patterns become important as systems evolve to depend more on object composition than class inheritance. As that happens, **emphasis shifts away from hard-coding a fixed set of behaviors toward defining a smaller set of fundamental behaviors that can be composed** into any number of more complex ones. Thus creating objects with particular behaviors requires more than simply instantiating a class." (Gamma et al) [Emphasis added]

* "...flexibility in *what* gets created, *who* creates it, *how* it gets created, and *when*. They let you configure a system with "product" objects that vary widely in structure and function." (Gamma et al)

* Reuse and error prevention. For instance, regarding the maze game, the naive approach is inflexible. "It hard codes the maze layout. Changing the layout means changing [the CreateMaze()] function, either by overriding it - which means reimplementing the whole thing - or by changing parts of it - which is error-prone and doesn't promote reuse." (Gamma et al)

* The particular flexibility of creational patterns is the ability "to change the classes that defined the components of a maze."

* For instance, we can "reuse an existing maze layout [with] enchanted mazes." Importantly, creational patterns let us reuse a layout while letting us change **what** we layout.

* In other words: 
  
  * Reuse the relationships; change the entities. 
  * Reuse the interactions; change the individuals.
  * Reuse the behavior; change the actors.
  * Reuse the layout; change the furniture.

### Advantages of Abstract Factory

### Advantages of Factory Method

### Advantages of Builder

### Advantages of Prototype

### Advantages of Singleton