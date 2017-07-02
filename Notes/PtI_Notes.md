# Program to interfaces not to implementations.


```
Car car = new StandardPassengerVehicle();

car.addDriver("Maroc");
car.addPassengers(2);

wash(car);
```

* Works well with but does not require factories and/or dependency injection. 
* The earliest mention of "program to interfaces" on Google is http://wiki.c2.com/?UseFactoriesToBuildObjects from 2001.

## vs the Dependency Inversion Principle (DIP)

* The DIP is more about what layer owns the interface.
* That is, in the DIP, the higher-level component defines the interface. 
* Note: we can only follow the DIP by programming to interfaces.

## vs Dependency Injection (DI)

* DI is more about where the implementation is created.
* In DI, the dependee does not create its dependencies.
* Note: we can do DI without programming to interfaces.
