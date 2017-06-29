// this programs to an interfaces 
// and it depends on abstractions 
function doSomething(packageType: string, packageFactory: IPackageFactory) {  
    let package: IPackage; 
    if (packageType === "roofing") {  
        package = packageFactory.createRoofingPackage(); 
    } 
    if (packageType === "flooring") {  
        package = packageFactory.createFlooringPackage(); 
    }  
    package.tender(); 
    package.ship(); 
} 

