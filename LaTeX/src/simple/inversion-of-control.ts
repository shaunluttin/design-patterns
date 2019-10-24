abstract class FertalizeGardenProgram {

    private pourFertalizerOnSoil() { 
        // some implementation
    }

    // this is a hook
    protected abstract roughUpTheSoil(): void;

    public run() {
        // this is WHEN the roughUpTheSoil routine happens
        this.roughUpTheSoil();
        this.pourFertalizerOnSoil();
    }
}

export class LooseSoilProgram extends FertalizeGardenProgram {

    protected roughUpTheSoil(): void {
        // define loose soil routine
    }
}

export class RockySoilProgram extends FertalizeGardenProgram {

    protected roughUpTheSoil(): void {
        // define rocky soil routine
    }
}
