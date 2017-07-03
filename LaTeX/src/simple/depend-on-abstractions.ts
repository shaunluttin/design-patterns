// This is dependency inversion.
// Both the higher-level juicer and the lower-level components 
// depend on an abstraction.
export function juicer(ingredients: Array<Juiceable>): Array<string> {
    // Dependency inversion leverages programming to interfaces.
    return ingredients.map((i) => i.juice());
}

export interface Juiceable {
    juice(): string;
}

// orange and carrot are lower-level modules
export class Orange implements Juiceable {
    public juice() {
        return "orange juice";
    }
}

export class Carrot implements Juiceable {
    public juice() {
        return "carrot juice";
    }
}
