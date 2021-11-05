function makeOrangeCarrotJuice(): Array<string> {

    const medley = new Array<string>();

    const orange: Juiceable = new Orange();
    const carrot: Juiceable = new Carrot();

    // The following is programming to Juiceable interfaces
    for (const juicable of [orange, carrot]) {
        const juice = juicable.squeeze();
        medley.push(juice);
    }

    return medley;
}

class Orange implements Juiceable {
    public squeeze = () => "orange juice";
    public peel = () => { /* peel the orange */ }
}

class Carrot implements Juiceable {
    public squeeze = () => "carrot juice";
    public chop = () => { /* chop the carrot */ }
}














/* Out of frame at ln 40 */
export interface Juiceable {
    squeeze(): string;
}
