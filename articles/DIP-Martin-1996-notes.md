
The dependency inversion principle is a "structural implication of the OCP and the LSP." (p 01)

[When teaching/presenting, it might be worth putting OCP and LSP before DIP.]

* OCP: Open-Closed Principle
* LSP: Liskov Substitution Pricinple
* DIP: Dependency Inversion Principle

Bad design has three criteria: 

1. rigidity, changing something means changing everything
1. fragility, making a change tends to break things
1. immobility, it is hard to use it in other applications

Those critera make the design 

1. expensive to change, 
2. expensive to re-use.

(p 02-03)

Example: The Copy Program

The copy program has a traditional dependency structure: the high-level module depends on low-level concrete classes.

```
import readKeyboard from "./keyboard";
import writePrinter from "./printer";

function copy() {
    let c: number; 
    while ((c = readKeyboard()) {
        writePrinter(c);    
    }
}
```

* Keyboard and Printer are low-level modules. 
  * They are also reusable in other programs.
* The Copy module is a high-level module
  * it depends two concrete classes,
  * we cannot reuse it with a Keyboard and Disc,
  * without modifying the source code.

Dependency Inversion

* Traditionally, high-level modules depend on low-level modules:
* `Higher` ---> `Concrete Middle` ---> `Concrete Lower` ---> ...
* Dependency Inversion inverts that:
* `Higher` ---> `Abstraction` <--- `Concrete Middle` ---> `Abstraction` <--- `Concrete Lower` ...

> Thus, the dependencies have been inverted; 
> the "Copy" class depends upon abstractions, 
> and the detailed readers and writers depend upon the same abstractions.

(p 05)

The Dependency Inversion Princple

A: High-level modules should not depend on low-level modules. Both should depend on abstractions.

* [The copy program example illustrates what not to do: Copy depends on Keyboard and Printer.]

B: Abstractions should not depend on details. Details should depend on abstractions.

* [The copy program example does not illustrate what not to do: there is no example of an abstraction depending on a concrete class.]

Traditional, procedural methods, such as Structured Analysis and Design, tend to encorage both "should not" commandments.

* That means a change in a low-level module cascades into high-level modules.
* It also makes high-level modules hard to re-use without bringing along the low-level modules.

(p 06)
