class Orange implements Juiceable {
    public squeeze() {
        return new Juice("orange juice");
    }
}

class Carrot implements Juiceable {
    public squeeze() {
        return new Juice("carrot juice");
    }
}

// The juicer is programming to interfaces.
// The following only cares that it is dealing with Juiceables.
function orangeCarrotJuice(juiceGarden: JuiceGarden): Array<Juice> {

    const orange: Juiceable = juiceGarden.pickOrange();
    const carrot: Juiceable = juiceGarden.pickCarrot();

    let ingredients: Array<Juiceable> = [orange, carrot];

    return ingredients.map((j: Juiceable) => j.squeeze());
}
















/* Out of frame at ln 40 */
export interface Juiceable {
    squeeze(): Juice;
}

class Juice {
    constructor(private name: string) { }
}

class JuiceGarden {

    pickOrange(): Juiceable {
        return new Orange();
    }

    pickCarrot(): Juiceable {
        return new Carrot();
    }
}
