namespace GeometryCalcs;

public class Triangle : Shape
{
  private readonly double[] _sides;

  public Triangle(
    double a,
    double b,
    double c
  ) : base(
    Math.Sqrt(
      (a + b + c) / 2 * ((a + b + c) / 2 - a) * ((a + b + c) / 2 - b)
      * ((a + b + c) / 2 - c)
    )
  )
  {
    if (a <= 0 || b <= 0 || c <= 0)
      throw new ArgumentException("One or many sides less or equal to zero");

    if (a + b < c || a + c < b || b + c < a)
      throw new ArgumentException("Triangle with this sides are impossible");

    _sides = new[] { a, b, c };
  }

  public bool isRight(double eps = 1E-6)
  {
    Array.Sort(_sides);
    return Math.Abs(
             Math.Pow(_sides[0], 2) + Math.Pow(_sides[1], 2)
             - Math.Pow(_sides[2], 2)
           )
           <= eps;
  }
}
