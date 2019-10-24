import Observer from "./observer";
import Subject from "./subject";
import Timer from "./timer";

export default class ConsoleClock extends Observer {

    private subject: Timer;

    constructor(timer: Timer) {
        super();
        this.subject = timer;
        this.subject.attach(this);
    }

    public update(theChangedSubject: Subject) {
        if (theChangedSubject === this.subject) {
            console.log("seconds:" + this.subject.seconds)
        }
    }
}