using MindboxTask.Shape.TriangleShape.Interfaces;

namespace GeometricLibTests;

public class GeometricLibTriangleTest
{
    [Theory]
    [ClassData(typeof(RectangularTriangleTestCase))]
    public void IsRectangularTriangleTest(ITriangleShape shape, bool expectedResult)
    {
        var res = shape.IsRectangular();
        Assert.Equal(expectedResult, res);
    }
}