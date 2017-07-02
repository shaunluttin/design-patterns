import info from "./logger";
import Organ from "./organ";
import Human from "./human";

export default class Heart extends Organ {

    private millisecondsPerMinute = 60 * 1000;

    private beatsPerMinute = 50;

    private beatIntervalId: number;

    public afterAttachHost(): void {
        this.pumpBlood();
    }

    private pumpBlood() {

        const beatInterval =
            this.millisecondsPerMinute / this.beatsPerMinute;

        this.beatIntervalId = setInterval(
            () => {
                if (this.host.isAlive) {
                    info("pump blood");
                } else {
                    this.die();
                }
            },
            beatInterval);
    }

    public massiveHeartAttack() {
        clearInterval(this.beatIntervalId);
        this.host.die();
    }

    private die() {
        info("heart is shutting down");
        clearInterval(this.beatIntervalId);
    }
}