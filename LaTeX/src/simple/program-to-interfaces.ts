export interface Juiceable {
    juice(): string;
}

class Orange implements Juiceable {
    public juice() {
        return "orange juice";
    }
}

class Carrot implements Juiceable {
    public juice() {
        return "carrot juice";
    }
}

function createJuiceMedly(): Array<string> {

    let ingredients: Array<Juiceable> = [
        new Orange(),
        new Carrot()
    ];

    // This is programming to interfaces.
    // The call to `map` only cares that it is dealing with Juiceables.
    return ingredients.map((j: Juiceable) => j.juice());
}

// run
const juice = createJuiceMedly();
