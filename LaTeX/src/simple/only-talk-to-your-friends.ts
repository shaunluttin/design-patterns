class Farmer {

    private equipment: Array<FarmEquipment>;

    // In the formal definition of the Law of Demeter
    // a method of an object must only call members of...
    public digHole(place: Place) {

        // objects created within the method,
        const shovel = new Shovel();
        shovel.dig(place);

        // the object itself,
        this.decreaseEnergyLevel();

        // direct properties/fields of the object, or
        this.equipment.push(shovel);

        // any argument of the method.
        let placeName = place.getName();

        // BAD: the Farmer now knows too much about the system.
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