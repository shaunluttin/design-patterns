/*
 * Is this single responsibility?  Arguably, there are several responsibilties:
 *
 * 1. preparing the raised bed before planting
 * 2. maintaining it after planting
 * 3. harvesting
 * 4. accounting
 *
 * If harvesting requests a change, is it easy to mistakenly break the preparation department?
 *
 * If someone wants to buy just the harvesting features of the system, do we also
 * need to ship them the maintenance and preparation features?
 */
class RaisedBed {
    public addCompost() { }
    public addMulch() { }
    public addSeeds() { }
    public addWater() { }
    public pullWeeds() { }
    public harvestProduce() { }
    public getYearlyRevenue() { }
    public setProducePrices() { }
}
