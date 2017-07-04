class Farmer {

    private equipment: Array<FarmEquipment>;

    private energyLevel: number;

    // A method of an object may only call methods of: 
    public DigHole(place: Place) {

        const shovel = new Shovel();

        while (this.energyLevel > 0) {
            // 1. The object itself.
            this.decreaseEnergyLevel();
            // 2. Any argument of the method.
            const target = place.getHighestPlaceWithin();
            // 3. Any object created within the method.
            shovel.dig(target);
        }

        // 4. Any direct properties/fields of the object.
        this.equipment.push(shovel);
    }

    private decreaseEnergyLevel() {
        this.energyLevel = this.energyLevel - 1;
    }
}











/* Out of frame at ln 40 */
class Place {
    getHighestPlaceWithin(): any { }
}

class Shovel implements FarmEquipment {
    dig(place: Place) { }
}

interface FarmEquipment { }