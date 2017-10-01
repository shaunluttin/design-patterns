/* 
 * This is a better segregation of responsibilities.
 * 
 * E.g. A client can now use the harvesting component independencly. 
 */

class RaisedBedPreparationService {

    public addCompost() { }

    public addMulch() { }

    public addSeeds() { }
}

class RaisedBedMaintenacenService {

    public addWater() { }

    public pullWeeds() { }
}

class RaisedBedHarvestService {

    public harvestProduce() { }
}
