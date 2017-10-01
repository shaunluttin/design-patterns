// The lower level module depends on the abstraction.
// Thereby letting it plugin to the higher level module.
import { Juiceable } from "./depend-on-abstractions-higher";

export class Orange implements Juiceable {
    public squeeze = () => "orange juice";
}

export class Carrot implements Juiceable {
    public squeeze = () => "carrot juice";
}



























/* Out of frame at ln 40 */

