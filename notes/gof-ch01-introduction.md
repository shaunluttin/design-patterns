These are notes from the introduction chapter from Design Patterns (Gamma et al, 1994).

## Intro

* Good OO designs allow
    * reuse
    * flexibility
* getting those "right" often taken several iterations
* stand on shoulders; do not resolve these problem
* GOF catalogs patterns from existing systems

## What is a design pattern? 

* repeated problem > core of a solution > inspiration for your solution
* "a [generalized] solution to a problem in a context"
* four parts
    * name
    * problem
    * solution
    * consequences [outcome]
* "descriptions of communicating objects and classes that are customized to solve a general design problem in a particular context"

## Design patterns in Smalltalk MVC

* MVC decouples these three to enable reuse/flexibility
    * model: application object
    * view: its screen presentation
    * controller: how the UI reacts to user input
* There are patterns in there
    * The view-model relationship is an *Observer* pattern
    * Nested views are a *Composite* pattern
    * The view-controller relationship is a *Strategy* pattern

## Describing design patterns

* name: the pattern's essense 
* classification: 
* intent: what does the pattern do?
* aka: other names
* motivation: the problem and its solution
* applicability: when to use it
* structure: graphical representation of its classes
* participants: responsibilities of its classes and objects
* collaborations: how the classes/objects interact
* consequences: pros/cons & what the pattern allows us to vary independently
* implementation: pitfalls, hints, techniques, subtleties
* sample code: C++/Smalltalk
* known uses: where did the GOF find it?
* related patterns: comparison to similar patterns & commonly collaborating patterns

## The catalog of desing patterns

* the name and 
* the intent

## Organizing the catalog

* purpose: the pattern's intent
    * creational (x05): creating objects
    * structural (x08): composing classes/objects
    * behavioral (x11): interacting classes/objects
* scope: the pattern's focus
    * class  (x04): static, fixed at compile-time, subclasses, inheritance
    * object (x20): dynamic, changeable at run-time, object relationships
* defer to subclass -vs- defer to object
* inheritance to compose classes -vs- composition to assemble objects
* inheritance to describe algorithms -vs- cooperating objects to perform tasks

## How design patterns solve design problems

These are the XXX design problems that design patterns help to solve.

### Problem: Finding appropriate objects

objects are *encapsulated*

* "an object packages both data and the procedures that operate on that data"
* "an object performs an operation when it receives a request (or message) from a client"
* its "internal state ... cannot be accessed directly, and its representation is invisible from outside"

decomposing a system into objects is difficult; some approaches

* write a problem statement; nouns become objects, verbs become operations
* focus on collaborations & responsibilities
* model the real world as objects and interactions

> Strict modeling of the real world leads to a system that reflects today's realities but not necessarily tomorrow's.

Design patterns 

* help us find abstractions that are not found in the real world 
* but that make a system more flexible and reusable.

### Problem: Determining object granularity

* some objects represent large concepts (e.g. a Facade)
* other objects represent tiny ideas (e.g. Flyweight)

### Problem: Specifying object interfaces

* an *interface* is a set of requests/messages an object will accept
* an interface has many signatures, which include an operation's
    * name
    * parameters
    * return value
* a *type* is the name of a specific interface
    * an object may have many different types
    * widely different objects may share a type
    * clients know objects only through their interfaces
* a *subtype*'s interface contains/inherits the interface of its *supertype*
* *dynamic binding* is the "run-time association of a request to an object and one of its operations"
* this enables *polymorphism*: the substitution of different implementations of the same type
    * simplifies the defn of clients
    * decouples objects from each other
    * lets them vary their relationships at runtime
* design patterns help us 
    * choose what (not) to include in an interface
    * define relationships among interfaces

### Problem: Specifying object implementations

Class vs interface inheritance

Programming to an interface, not an implementation

### Problem: Putting reuse mechanisms to work

Inheritance vs composition

Delegation

Inheritance vs parameterized types

### Problem: Relating run-time and compile-time structures

### Problem: Designing for change

Application programs

Toolkits

Framworks

## How to select a desing pattern

## How to use a design pattern


