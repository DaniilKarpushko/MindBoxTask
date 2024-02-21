using MindboxTask.Shape.TriangleShape.Interfaces;

namespace MindboxTask.Shape.TriangleShape.Entities;

public class TriangleShape : ITriangleShape
{
    private readonly float _sideA;
    private readonly float _sideB;
    private readonly float _sideC;

    public TriangleShape(float sideA, float sideB, float sideC)
    {
        _sideA = sideA;
        _sideB = sideB;
        _sideC = sideC;
    }

    public double CountSquare()
    {
        var p = (_sideC + _sideB + _sideA) / 2;
        return Math.Sqrt(p * (p - _sideA) * (p - _sideB) * (p - _sideC));
    }

    public bool IsRectangular()
    {
        return Math.Abs((_sideA * _sideA + _sideB * _sideB + _sideC * _sideC)
                        - 2 * Math.Max(_sideC, Math.Max(_sideA, _sideB)) * Math.Max(_sideC, Math.Max(_sideA, _sideB)))
               < 0.000001;
    }
}