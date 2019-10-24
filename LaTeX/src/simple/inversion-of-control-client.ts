import {
    LooseSoilProgram,
    RockySoilProgram,
} from "./inversion-of-control";

const program1 = new LooseSoilProgram();
program1.run();

const program2 = new RockySoilProgram();
program2.run();
