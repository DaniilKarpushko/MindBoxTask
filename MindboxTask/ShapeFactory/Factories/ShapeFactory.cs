using MindboxTask.Shape.CircleShape.Entities;
using MindboxTask.Shape.Interfaces;
using MindboxTask.Shape.TriangleShape.Entities;
using MindboxTask.ShapeFactory.Interfaces;

namespace MindboxTask.ShapeFactory.Factories;

class ShapeFactory : IShapeFactory
{
    public IShape CreateСircle(float radius)
    {
        return new CircleShape(radius);
    }

    public IShape CreateTriangle(float sideA, float sideB, float sideC)
    {
        if (sideA + sideB > sideC &&
            sideA + sideC > sideB &&
            sideB + sideC > sideA)
        {
            return new TriangleShape(sideA, sideB, sideC);
        }
        return new TriangleShape(1,1,1);
    }
}