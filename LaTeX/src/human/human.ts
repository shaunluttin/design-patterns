import info from "./logger";
import Organ from "./organ";

export default class Human {

    private organs: Organ[];

    public isAlive: boolean;

    constructor(organs: Organ[]) {
        this.organs = organs;
        this.isAlive = true;
    }

    // principle: program to interfaces
    public doLife() {
        this.organs.forEach((organ) => {
            organ.attachHost(this);
        });
    }

    public die() {
        info("oh cruel world");
        this.isAlive = false;
    }
}