// Both the higher-level juicer and the lower-level components 
// depend on an abstraction.
namespace HigherLevel {

    export function juicer(ingredients: Array<Juiceable>): Array<string> {
        // Dependency inversion leverages programming to interfaces.
        return ingredients.map((i) => i.juice());
    }

    // The higher level module owns the abstraction on which it depends.
    export interface Juiceable {
        juice(): string;
    }
}

namespace LowerLevel {

    export class Orange implements HigherLevel.Juiceable {
        public juice() {
            return "orange juice";
        }
    }

    export class Carrot implements HigherLevel.Juiceable {
        public juice() {
            return "carrot juice";
        }
    }
}










/* Out of frame at ln 40 */
