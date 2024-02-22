using MindboxTask.Shape.Interfaces;

namespace MindboxTask.ShapeFactory.Interfaces;

public interface IShapeFactory
{
    IShape CreateСircle(float radius);
    IShape CreateTriangle(float sideA, float sideB, float sideC);
}