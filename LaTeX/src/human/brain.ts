import Organ from "./organ";
import info from "./logger";
import Human from "./human";

export default class Brain extends Organ {

    private thoughtInterval: 2000;

    private thoughtIntervalId: number;

    public afterAttachHost(): void {
        this.thinkThoughts();
    }

    private thinkThoughts() {
        this.thoughtIntervalId = setInterval(
            () => {
                if (this.host.isAlive) {
                    info("think think think");
                } else {
                    this.die();
                }
            }, this.thoughtInterval)
    }

    private die() {
        info("brain is shutting down");
        clearInterval(this.thoughtIntervalId);
    }
}