import Subject from "./subject";

export default abstract class Observer {

    public abstract update(theChangedSubject: Subject): void;
}
