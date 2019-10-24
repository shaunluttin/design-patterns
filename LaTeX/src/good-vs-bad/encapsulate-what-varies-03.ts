// SomeFile01.cs
this.Tax += this.Price * 0.07;

// SomeFile02.cs
product.Tax += product.Price * 0.05;

// SomeFile03.cs
If (product.Type === "accommodation") {
    Product.Tax -= product.Price * 0.07;
    product.Tax += product.Price * 0.08;
}

// The way we calculate tax in British Columbia might change.

product.Tax = 
    _taxService.calculateTax(product);?



