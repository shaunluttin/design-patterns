class Product {
    public price: number;
}

// We have encapsulated the calculation of tax.
class TaxCalculator {
    public calculateTax(product: Product): number {
        // Do the calculation of tax.
        return 0;
    }
}

class FarmStand {

    private cart: Array<Product>;

    public CalculateGrandTotal(): number {
        let total = 0;
        const taxCalculator = new TaxCalculator();
        for (const product of this.cart) { 
            const tax = taxCalculator.calculateTax(product);
            total += product.price + tax;
        }

        return total;
    }
}












/* Out of frame at ln 40 */
