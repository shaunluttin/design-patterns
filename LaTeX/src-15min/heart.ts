import info from "./logger";
import Organ from "./organ";
import Human from "./human";

export default class Heart extends Organ {

    private millisecondsPerMinute = 60 * 1000;

    private beatsPerMinute = 50;

    public afterAttachHost(): void {
        this.pumpBlood();
    }

    private pumpBlood() {

        const beatInterval =
            this.millisecondsPerMinute / this.beatsPerMinute;

        setInterval(
            () => info("pump blood"),
            beatInterval);
    }
}