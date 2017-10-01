class Farmer {

    private equipment: Array<FarmEquipment>;

    // A method of an object may only call methods of: 
    public digHole(place: Place) {

        // Any object created within the method.
        const shovel = new Shovel();
        shovel.dig(place);

        // Any direct properties/fields of the object.
        this.equipment.push(shovel);

        // The object itself.
        this.decreaseEnergyLevel();

        // Any argument of the method.
        let placeName = place.getName();

        // BAD: Farmer knows too much about the system.
        placeName = place.details.locationDetails.name;
    }

    private decreaseEnergyLevel = () => { };
}













/* Out of frame at ln 40 */
class Place {

    public details = {
        locationDetails: {
            name: "foo bar baz"
        }
    };

    getName(): any {
        return this.details.locationDetails.name;
    }
}

class Shovel implements FarmEquipment {
    dig(place: Place) { }
}

interface FarmEquipment { }