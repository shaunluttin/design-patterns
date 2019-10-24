interface Shape {
  draw();
}

class Circle implements Shape {
  public draw() { }
}

class Square implements Shape {
  public draw() { }
}

function drawAllShapes(shapes: Shape[]) {
  shapes.forEach((s) => s.draw());
}
