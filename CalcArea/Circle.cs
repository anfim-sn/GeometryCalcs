namespace GeometryCalcs;

public class Circle : Shape
{
  public Circle(double r) : base(r * r * Math.PI)
  {
    if (r <= 0)
      throw new ArgumentException("Radius less or equal to zero");
  }
}
