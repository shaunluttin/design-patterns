
SRP-Martin-2003.pdf

* From Agile Design Princples, 2003
* Originally from DeMarco & Page-Jones (year?)
  * cohesion
  * "functional relatedness of the elements of a module"
* Martin shifts the meaning to, "the forces that cause a module, or a class, to change."

A class should have only one reason to change.

E.g. 1: Game class was keeping track of the current frame AND was keeping score of the game.

* The refactor kept game keeping track of the frame, adding a Scorer class that kept track of score.
* Why? 
  * Each responsibility is an axis-of-change.
  * If a class has multiple responsibilities, then those responsibilities are *coupled*.
  * Changing one responsibility may hinder the classes ability to perform other responsibilities.

E.g. 2: Rectangle class was handling its geometry AND its presentation. 

* Problem: 
   * A computational application must bring along the presentation code. 
   * A graphical application must bring along the computational code.
   * This means building, deploying...
* Solution: Break rectangle into two classes: 1. GraphicalRectangle, 2. ComputationalRectagle

What is a responsibility? 

* "a reason to change"
* a "motive for changing a class"
* [note that Martin is talking about classes, which implies a static, compile time entity, i.e. source code]

* E.g. 3: Modem class has *two* responsibilities: connection management AND data communication
  * Dial
  * Hangup
  * Send
  * Receive
* Question: should we separate the two responsibilities? 
* Answer: It depends on how the application is changing. 
  * If the Dial/Hangup change without changing Send/Receive,
  * that's rigidity, 
  * because on that change, we must needlessly recompile and deploy
  * classes that depend only on Send/Receive.
  * In that case, we ought to separate concerns.
  * *Rigidity*: when a change in X requires recompiling classes that do not depend on X.
  * If the Dial/Hangup only change along with changes to Send/Receive,
  * then we ought not to separate concerns, 
  * lest we fall into needless complexity.
  * *Needless complexity*: when we separate concerns that always change together.

* Corrolary: "an axis of change [only matters] if the changes [are likely to] occur." 
* Compromise: 
  * sometimes we only separate responsibilities in the abstraction 
  * while keeping the responsibilities coupled in the implementation. 

E.g. 4 Persistence, the Employee class couples business rules AND persistence control.

* these should almost never be mixed,
* because business rules commonly change independencly of persistence control mechamisms.



