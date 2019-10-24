enum ShapeType {circle, square};

class Shape {
  itsType: ShapeType;
}

class Circle extends Shape {
  itsType: ShapeType;
  itsRadius: number;
}

class Square extends Shape {
  itsType: ShapeType;
  itsSide: number;
}

function drawSquare(square: Square) { }
function drawCircle(circle: Circle) { }

function drawAllShapes(shapes: Shape[]) {
    shapes.forEach((s) => { 
        switch (s.itsType) { 
            case ShapeType.circle: 
              DrawCircle(s as Circle); 
              break;
            case ShapeType.square: 
              DrawSquare(s as Square); 
              break;
        }
    });
}
