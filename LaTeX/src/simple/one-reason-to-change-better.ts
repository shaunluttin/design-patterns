/* 
 * This is one alternative divsion of responsibilities.
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

class PricingService {
    public setProducePrices() { }
}

class RevenueService {
    public getYearlyRevenue() { }
}
