import Organ from "./organ";
import info from "./logger";
import Human from "./human";

export default class Heart extends Organ {

    public afterAttachHost(): void {
        this.pumpBlood();
    }

    private pumpBlood() {
        setInterval(() => {
            info("pump blood");
        }, 1000)
    }
}