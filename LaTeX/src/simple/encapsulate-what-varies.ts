class Product {
    public price: number;
}

// We have encapsulated the calculation of tax.
class TaxCalculator {

    public calculateTax(product: Product): number {
        // This does complex, involved calculation of tax.
        return 0;
    }
}

class FarmStand {

    private cart: Array<Product>;

    public CalculateTotalTax(): number {

        const taxCalculator = new TaxCalculator();
        let totalTax = 0;

        for (const product of this.cart) { 
            totalTax += taxCalculator.calculateTax(product);
        }

        return totalTax;
    }
}










/* Out of frame at ln 40 */
