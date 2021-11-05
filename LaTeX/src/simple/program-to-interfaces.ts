interface ITaxCalculator {
    calculateTax(product: Product): number;
}

class FarmStandToo {

    private cart: Array<Product> = [];

    // We are now programming to interfaces not implementations.
    // This supports the ... principle.
    constructor(private taxCalculator: ITaxCalculator) { }

    public CalculateTotalTax(): number {

        let totalTax = 0;

        for (const product of this.cart) { 
            totalTax += this.taxCalculator.calculateTax(product);
        }

        return totalTax;
    }
}