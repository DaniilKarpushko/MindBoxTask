using System.Collections;
using MindboxTask.Shape.TriangleShape.Entities;

namespace GeometricLibTests;

public class RectangularTriangleTestCase : IEnumerable<object[]>
{
    public IEnumerator<object[]> GetEnumerator()
    {
        yield return new object[]
        {
            new TriangleShape(3, 4, 5),
            true,
        };
        
        yield return new object[]
        {
            new TriangleShape(1, 4, 5),
            false,
        };
        
        yield return new object[]
        {
            new TriangleShape(0.012f,0.013f , 0.005f),
            true,
        };
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}