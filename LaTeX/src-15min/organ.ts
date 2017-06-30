import Human from "./human";

// principle: dependency inversion principle
// the Human owns the interface for the Organ
export default abstract class Organ {

    protected host: Human;

    public attachHost(host: Human) {
        this.host = host;
        this.afterAttachHost();
    }

    public abstract afterAttachHost(): void;
}