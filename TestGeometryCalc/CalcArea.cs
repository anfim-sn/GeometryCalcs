using GeometryCalcs;

namespace TestGeometryCalc;

public class CalcArea
{
  [Fact]
  public void CalcCircleArea_ValidDouble_toBeSuccess()
  {
    double r = 5;
    var expect = 78.54;
    var actual = new Circle(r).Area;
    Assert.Equal(expect, actual);
  }

  [Fact]
  public void CalcTriangleArea_ValidDouble_toBeSuccess()
  {
    double a = 4;
    double b = 5;
    double c = 6;
    var expect = 9.922;
    var actual = new Triangle(a, b, c).Area;
    Assert.Equal(expect, actual);
  }

  [Fact]
  public void TriangleIsRight_ValidDouble_toBeSuccess()
  {
    var a = 4.4;
    var b = 5.2;
    var c = 6.81175454637;
    var actual = new Triangle(a, b, c).isRight();
    Assert.True(actual);
  }
}
