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

* A *class* defines an object's implementation.
    * internal data
    * operations
* *Instantiating* a class creates an object *instance* 
    * allocates storage for the internal data
    * associates operations with that data
* *inheritance* defines a subclass in terms of an existing class
* subclass objects incl. the parent classes data and operations
* an *abstact class* cannot be instantiated; its purpose is to parent subclasses
* an *abstract operations* is an operation without an implementation
* the opposite is *concrete*
* a *subclass* can override and thereby refine its parent classes' operations
* a *mixin class* requires multiple inheritance; it provides an optional interface

#### Class vs interface inheritance

Many design patterns rely on the distinction between 

* class (implementation) inheritance and 
* interface inheritance.

Definitions

* class
    * defines the interface implementation and the internal state
    * objects of different classes can have the same types
* type 
    * defines only the interface interface of acceptable requests
    * an object can have many types
* class (implementation) inheritance
    * defines an object's implementation...
    * in terms of another object's implementation
    * enables code sharing
* interface inheritance
    * describes when one object...
    * can be used in place of another object

Many languages do not make these distinctions explicit

* Smalltalk inheritance means only implementation (class) inheritance.
* C++ inheritance means both interface and class inheritance
    * Interface-only C++ inheritance means 
    * publically inheriting a pure abstract class 
    * with only pure virtual operations.
    * Implementation-only C++ inheritance means
    * privately inheriting from a class with concrete operations.

#### Programming to an interface, not an implementation

* inheritance enables 
    * reuse via subclassing
    * polymorphism via subtyping
* carefully done, inheritance never hides its parents' operations; benefits:
    * polymorphism!
    * clients care only that the the object adheres to the expected interface
    * clients remain unaware of the specific object type...
    * clients remain unaware of the specific object class...
    * this greatly reduces implementation dependencies b/w subsystems

> Program to an interface, not an implementation.

* That is: declare variables to be of an interface type not a concrete class type.

> Creational patterns ensure that your system is written in terms of interfaces, not implementations.

### Problem: Putting reuse mechanisms to work

#### Inheritance vs composition

#### Delegation

#### Inheritance vs parameterized types

### Problem: Relating run-time and compile-time structures

### Problem: Designing for change

#### Application programs

#### Toolkits

#### Framworks

## How to select a desing pattern

## How to use a design pattern

