import Subject from "./subject";

// TODO: what differentiates extends from implements in TypeScript
export default class Timer extends Subject {

    private _seconds: number = 0;

    public get seconds(): number {
        return this._seconds;
    }

    public set seconds(v: number) {
        this._seconds = v;
        this.notify();
    }

    public start() {
        setInterval(
            () => {
                this.seconds = this.seconds + 1
            },
            1000
        );
    }

}