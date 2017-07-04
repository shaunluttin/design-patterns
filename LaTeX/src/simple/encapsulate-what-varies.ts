class Product {
    public price: number;
}

// We have encapsulated the calculation of tax.
class TaxCalculator {
    public calculateTax(product: Product): number {
        const tax = 0;
        // Do the calculation of tax, 
        // which will likely change over time.
        return tax;
    }
}

class FarmStand {

    private cart: Array<Product>;

    public DisplayGrandTotal(): number {
        // Question: What else might we want to change without redesign?
        const taxCalculator = new TaxCalculator();
        return this.cart.reduce((sum, product) => {
            const tax = taxCalculator.calculateTax(product);
            const productGrandTotal = tax + product.price;
            return sum + productGrandTotal;
        }, 0);
    }
}











/* Out of frame at ln 40 */
