// The higher level module defines the abstraction.
export interface Juiceable {
    squeeze(): string;
}

// The higher level module depends on the abstraction.
export function makeJuice(ingredients: Array<Juiceable>) {

    const medley = new Array<string>();

    // The higher level no longer depends on the lower level conrete classes.
    // medley.push(new Orange().squeeze());
    // medley.push(new Orange().squeeze());
    // medley.push(new Carrot().squeeze());
    // medley.push(new Carrot().squeeze());

    for (const juicable of ingredients) {
        const juice = juicable.squeeze();
        medley.push(juice);
    }

    return medley;
}



















/* Out of frame at ln 40 */
