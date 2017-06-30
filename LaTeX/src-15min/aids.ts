import Disease from "./disease";
import info from "./logger";
import Human from "./human";

export default class AIDs extends Disease {

    public afterAttachHost(): void {
        this.damageImmuneSystem();
    }

    private damageImmuneSystem() {

    }
}