interface Rectangle {
    calculateArea(): number;
    draw();
}

function computationalApp(rectangle: Rectangle) {
    rectangle.calculateArea();
}

function graphicalApp(rectangle: Rectangle) {
    rectangle.draw();
}

