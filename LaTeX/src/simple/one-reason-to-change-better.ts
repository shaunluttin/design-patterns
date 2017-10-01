/* 
 * This is a better segregation of responsibilities.
 * 
 * E.g. A client can use the harvesting component independently. 
 */

class RaisedBedPreparationService {

    public addCompost() { }

    public addMulch() { }

    public addSeeds() { }
}

class RaisedBedMaintenanceService {

    public addWater() { }

    public pullWeeds() { }
}

class RaisedBedHarvestService {

    public harvestProduce() { }
}
