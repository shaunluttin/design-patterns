import Timer from "./timer";
import ConsoleClock from "./console-clock";
import OtherConsoleClock from "./other-console-clock";

const timer = new Timer();
timer.start();

const consoleClock = new ConsoleClock(timer);
const otherConsoleClock = new OtherConsoleClock(timer);
