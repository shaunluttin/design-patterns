import Observer from "./observer";
import Subject from "./subject";
import Timer from "./timer";

export default class OtherConsoleClock extends Observer {

    private subject: Timer;

    constructor(timer: Timer) {
        super();
        this.subject = timer;
        this.subject.attach(this);
    }

    public update(theChangedSubject: Subject) {
        if (theChangedSubject === this.subject) {
            const seconds = this.subject.seconds % 60;
            const minutes = Math.floor(this.subject.seconds / 60);
            const hours = 0; // TODO
            const time = `${hours}:${minutes}:${seconds}`;
            console.log("time:" + time);
        }
    }
}
