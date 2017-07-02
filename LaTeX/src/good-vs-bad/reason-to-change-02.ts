interface GeometricRectangle { 
    calculateArea(): number;
}

interface Rectangle {
    draw();
}

function computationalApp(rectangle: GeometricRectangle) {
    rectangle.calculateArea();
}

function graphicalApp(rectangle: Rectangle) {
    rectangle.draw();
}

