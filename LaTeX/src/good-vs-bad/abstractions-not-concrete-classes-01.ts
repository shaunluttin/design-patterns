// this programs to an interfaces
// but it depends on concrete classes
function doSomething(packageType: string) { 
    let package: IPackage;
    if (packageType === "roofing") { 
        package = new RoofingPackage(); // concrete lower layer
    }
    if (packageType === "flooring") { 
        package = new FlooringPackage(); // concrete lower layer
    } 
    package.tender();
    package.ship();
}

