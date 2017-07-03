// a passenger has a destination
export interface Passenger {
    getDestination(): any;
}

export class Child implements Passenger {
    getDestination(): any {
        throw new Error("Method not implemented.");
    }
}

export class Dog implements Passenger {
    getDestination(): any {
        throw new Error("Method not implemented.");
    }
}

export class Car {

    private destinations: Array<any>;

    public Accept(passenger: Passenger) {
        // this is an example of programming to interfaces
        this.destinations.push(passenger);
    }
}

const car = new Car();

car.Accept(new Child());
car.Accept(new Dog());