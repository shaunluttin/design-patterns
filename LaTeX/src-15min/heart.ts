import Organ from "./organ";
import info from "./logger";
import Human from "./human";

export default class Heart extends Organ {

    public afterAttachHost(): void {
        setInterval(() => {
            info("pump blood");
        }, 1000)
    }
}