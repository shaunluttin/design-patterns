import Human from "./human";

// human defines the interface for the organ
// organs are autonomously operating human components
export default abstract class Organ {

    protected host: Human;

    public attachHost(host: Human) {
        this.host = host;

        this.afterAttachHost();
    }

    public abstract afterAttachHost(): void;
}