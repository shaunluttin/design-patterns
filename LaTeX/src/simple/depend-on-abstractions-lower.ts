import { Juiceable, makeJuice } from "./depend-on-abstractions-higher";

// The lower level module depends on the abstraction.
class Orange implements Juiceable {
    public squeeze = () => "orange juice";
}

class Carrot implements Juiceable {
    public squeeze = () => "carrot juice";
}

// That lets it plug in to the higher level module.
makeJuice([
    new Orange(),
    new Orange(),
    new Carrot(),
    new Carrot()]
);
























/* Out of frame at ln 40 */

