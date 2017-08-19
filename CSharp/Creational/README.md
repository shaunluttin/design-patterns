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
  * Reuse the functionality; change the look and feel.

### Advantages of Abstract Factory

* Abstract factory provides an additional advantage: it "enforces dependencies between the concrete... classes." That is why the Abstract Factory is also known as the Kit pattern. It provides a tickety-boo kit of items that are meant to work together for a specific purpose.

* + "It isolates concrete classes" which makes it easy to change the concrete classes without changing the clients that use them.
* + "It makes exchanging product families easy" meaning we can swap out one product family for another with a single change to the client code.
* + "It promotes consistency among products" meaning it keeps us from using a product from family X with an incompatible product from family Y.
* - "Supporting new kinds of products is difficult" because this requires that we 1. create a new abstract product, 2. extend the abstract factory, 3. extend all of the concrete factories. 

### Advantages of Factory Method

### Advantages of Builder

### Advantages of Prototype

### Advantages of Singleton