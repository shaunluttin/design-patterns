class Product {
    public price: number;
}

// We have encapsulated the calculation of tax.
class TaxCalculator {
    public calculateTax(product: Product): number {
        throw new Error("TODO: Calculate the tax on the product.");
    }
}

class FarmStand {

    private cart: Array<Product>;

    public DisplayGrandTotal(): number {
        const taxCalculator = new TaxCalculator();

        return this.cart.reduce((sum, product) => {
            // Question: What else might we want to change without redesign?
            const tax = taxCalculator.calculateTax(product);
            const productGrandTotal = tax + product.price;
            return sum + productGrandTotal;
        }, 0);
    }
}
