// version2 without breaking version1
import GardenWateringSystem from "./open-closed";

// composition / decorating / wrapping 
class FilteringWateringSystem implements GardenWateringSystem {

    constructor(private baseSystem: GardenWateringSystem) { }

    public detectMoistureLevel = (): void =>
        this.baseSystem.detectMoistureLevel();

    public filterChemicalsFromWater() { }
}
