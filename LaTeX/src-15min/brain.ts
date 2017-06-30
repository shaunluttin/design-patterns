import Organ from "./organ";
import info from "./logger";
import Human from "./human";

export default class Brain extends Organ {

    public afterAttachHost(): void {
        this.thinkThoughts();
    }

    private thinkThoughts() {
        setInterval(() => {
            info("pump blood");
        }, 1000)
    }
}