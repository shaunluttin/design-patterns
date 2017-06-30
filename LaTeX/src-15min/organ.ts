import Human from "./human";

// human defines the interface for the organ
// that's important for the Dependency Inversion Principle
export default abstract class Organ {

    protected host: Human;

    public attachHost(host: Human) {
        this.host = host;
        this.afterAttachHost();
    }

    public abstract afterAttachHost(): void;
}