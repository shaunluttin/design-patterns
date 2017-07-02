import info from "./logger";
import Disease from "./disease";
import Human from "./human";

// principle: open-closed
export default class HumanWithDisease {

    private human: Human;

    private diseases: Disease[];

    constructor(human: Human, diseases: Disease[]) {
        this.human = human;
        this.diseases = diseases;
    }
}