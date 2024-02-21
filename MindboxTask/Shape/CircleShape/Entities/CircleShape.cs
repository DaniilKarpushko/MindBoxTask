using MindboxTask.Shape.CircleShape.Interfaces;
using MindboxTask.Shape.Interfaces;

namespace MindboxTask.Shape.CircleShape.Entities;

public class CircleShape : ICircleShape
{
    private readonly float _radius;

    public CircleShape(float radius)
    {
        _radius = radius;
    }

    public double CountSquare()
    {
        return Math.Pow(_radius, 2) * Math.PI;
    }
}