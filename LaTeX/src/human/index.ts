import Heart from "./heart";
import Brain from "./brain";
import Human from "./human";

const heart = new Heart();
const brain = new Brain();

const shaun = new Human([
    heart,
    brain
]);

shaun.doLife();

setTimeout(
    () => heart.massiveHeartAttack(),
    5 * 1000);