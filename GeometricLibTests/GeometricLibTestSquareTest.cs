using MindboxTask.Shape.CircleShape.Entities;
using MindboxTask.Shape.Interfaces;
using MindboxTask.Shape.TriangleShape.Entities;

namespace GeometricLibTests;

public class GeometricLibTestSquareTest
{
    [Fact]
    public void CircleSquareTestWithIntegerNumbersTrue()
    {
        IShape myShape = new CircleShape(10);
        var realResult = myShape.CountSquare();
        const double expectedResult = 314.15926535897933;

        Assert.Equal(expectedResult, realResult);
    }
    
    [Fact]
    public void CircleSquareTestWithFloatNumbersTrue()
    {
        IShape myShape = new CircleShape(2.312f);
        var realResult = myShape.CountSquare();
        const double expectedResult = 16.792893967753315;

        Assert.Equal(expectedResult, realResult);
    }
    
    

    [Fact]
    public void TriangleSquareTestWithIntegerNumbersTrue()
    {
        IShape myShape = new TriangleShape(3, 4, 5);
        var realResult = myShape.CountSquare();
        const double expectedResult = 6;

        Assert.Equal(expectedResult, realResult);
    }
    
    [Fact]
    public void TriangleSquareTestWithFloatNumbersTrue()
    {
        IShape myShape = new TriangleShape(3.31f, 10.45f, 7.9f);
        var realResult = myShape.CountSquare();
        const double expectedResult = 9.5224524748225399;

        Assert.Equal(expectedResult, realResult);
    }
}