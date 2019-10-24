import Observer from "./observer";

export default abstract class Subject {

    private observers: Observer[] = new Array<Observer>();

    public attach(observer: Observer) {
        var index = this.observers.indexOf(observer);
        if (index < 0) {
            this.observers.push(observer);
        }
    }

    public detach(observer: Observer) {
        var index = this.observers.indexOf(observer);
        if (index >= 0) {
            this.observers.splice(index, 1);
        }
    }

    public notify() {
        this.observers.forEach((o) => o.update(this));
    }
}
