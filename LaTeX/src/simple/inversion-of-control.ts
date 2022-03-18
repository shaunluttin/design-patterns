abstract class FertalizeGardenFramework {

    // this is a hook
    protected abstract pourFertalizerOnSoil(): void;

    // this is a hook
    protected abstract roughUpTheSoil(): void;

    public run() {
        // this is WHEN the roughUpTheSoil routine happens
        this.roughUpTheSoil();
        this.pourFertalizerOnSoil();
    }
}

export class LooseSoilProgram extends FertalizeGardenFramework {
    protected pourFertalizerOnSoil(): void {
        throw new Error('Method not implemented.');
    }

    protected roughUpTheSoil(): void {
        throw new Error('Method not implemented.');
    }
}

export class RockySoilProgram extends FertalizeGardenFramework {
    protected pourFertalizerOnSoil(): void {
        throw new Error('Method not implemented.');
    }

    protected roughUpTheSoil(): void {
        throw new Error('Method not implemented.');
    }
}