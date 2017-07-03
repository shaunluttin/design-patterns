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

function juicer(oranges: Array<Orange>, carrots: Array<Carrot>): Array<string> {

    // This is programming to interfaces.
    // The following only cares that it is dealing with Juiceables.
    let ingredients: Array<Juiceable> = oranges.concat(carrots);
    return ingredients.map((j: Juiceable) => j.juice());
}
