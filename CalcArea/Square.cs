namespace GeometryCalcs;

internal class Square : Shape
{
  public Square(double a, double b) : base(a * b)
  {
    if (a <= 0 || b <= 0)
      throw new ArgumentException("Sides are less or equal to zero");
  }
}
