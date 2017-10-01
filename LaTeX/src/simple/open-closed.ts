// we have shipped this, clients love it, zero bugs!
class GardenWateringSystem {

    // some operations

    public detectMoistureLevel() { }
}

// version2 without breaking version1

// inheritance
class SolarWateringSystem extends GardenWateringSystem {

    public chargeFromSolarPower() { }
}

// composition / decorating / wrapping 
class FilteringWateringSystem implements GardenWateringSystem {

    constructor(private baseSystem: GardenWateringSystem) { }

    public detectMoistureLevel = (): void =>
        this.baseSystem.detectMoistureLevel();

    public filterChemicalsFromWater() { }
}
