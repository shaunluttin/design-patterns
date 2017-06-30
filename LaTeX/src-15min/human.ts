import Organ from "./organ";

export default class Human {

    private organs: Organ[];

    public IsAlive: boolean;

    constructor(organs: Organ[]) {
        this.organs = organs;
    }

    doLife() {
        this.organs.forEach((organ) => {
            organ.attachHost(this);
        });
    }
}