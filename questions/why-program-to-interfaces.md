How is programming to an interface helpful *on its own*?

I.e. without also "depending on abstractions?"

It seems to me that programming to an interface (not an implementation) is not valuable unless we are also depending on abstractions. For instance, when we do `SomeInterface s = new SomeImplementation()`, that lets us program to the interface, but setting the `s` variable to an instance of `SomeImplementation` means we are *really* programming to an implementation. Other than being a stepping stone towards dependency inversion, how is programming to interfaces useful on its own?

Notes from https://stackoverflow.com/a/384067/1108891

* interfaces are a way of "classifying common traits or behaviors that [are] exhibited by ... non-related classes of objects."
* [the example also makes use of the dependency inversion principle, so it does not answer my question.]

Notes from https://stackoverflow.com/a/383982/1108891

* Programming to an interface is a way of programming to a thin slice of the actual implementation,
* without being at risk of accessing contextually inappropriate aspects. 
* [Consider a Person object,
* [that implement's both the Friend interface and the Employee interface.
* [As a friend of the Person, I want to be sure to program to the person's Friend interface,
* [otherwise, I might accidentally treat my friend like an employee!
* [As an employer, I want to program to the Employee interface,
* [otherwise I might accidentally blur workplace boundaries.
* "you already know that the rest of your code doesn't do anything that will be broken by changing the implementation" *<------*

Notes from Design Patterns by Gamma et al (location 617)

* Polymorphism depends on defining families of objects with *identical* interfaces.
* "there are two benefits to manipulating objects ... in terms of the interfaces...
  1. "clients remain unaware of the specific types of objects they use..."
    * [This advantage seems more like "depend on abstractions."]
  1. "clients remain unaware of the classes that implement these objects..."
    * [How is this second advantage different from the first advantage?
    * [I thought that being unaware of an object's type 
    * [is synonymous to being unaware of the class that implements the object.]
* "this ... greatly reduces implementation dependencies between subsystems..."

> You have to instantiate concrete classes ... somewhere in your system...
> and the creational patterns let you do just that... these patterns
> give you different ways to associate an interface with its implementation
> transparently at instantiation. Creational patterns ensure that your system
> is written in terms of interfaces, not implementations.

So, Gamma et al introduce the Creational Patterns under the heading of "Programming to an Interface, not an Implementation". That implies that "programming to interfaces" is most useful (if not only useful) when the client is not directly instantiating the implementation. *This seems a lot like the dependency inversion principle!*

Notes from http://wiki.c2.com/?UseFactoriesToBuildObjects (2001)

* TODO Add notes
* TODO Add notes
* TODO Add notes


