// We have encapsulated the calculation of tax.
class TaxCalculator {

    public calculateTax(product: Product): number {
        // This does the calculation of tax
        return 0;
    }
}

class FarmStand {

    private cart: Array<Product> = [];

    public CalculateTotalTax(): number {

        const taxCalculator = new TaxCalculator(); // Smelly...
        let totalTax = 0;

        for (const product of this.cart) { 
            totalTax += taxCalculator.calculateTax(product);
        }

        return totalTax;
    }
}














/* Out of frame at ln 40 */
type Product = {
    price: number;
}
