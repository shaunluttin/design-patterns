namespace HigherLevel {

    // The higher level module defines the abstraction.
    export interface Juiceable {
        squeeze(): string;
    }

    // The higher level module depends on the abstraction.
    export function juicer(ingredients: Array<Juiceable>): Array<string> {
        // Note: dependency inversion leverages programming to interfaces.
        let juice = new Array<string>();
        for (const i of ingredients) {
            juice.push(i.squeeze());
        }

        return juice;
    }

}

namespace LowerLevel {

    // The lower level module depends on the abstraction.
    export class Orange implements HigherLevel.Juiceable {
        public squeeze = () => "orange juice";
    }

    export class Carrot implements HigherLevel.Juiceable {
        public squeeze = () => "carrot juice";
    }
}











/* Out of frame at ln 40 */
