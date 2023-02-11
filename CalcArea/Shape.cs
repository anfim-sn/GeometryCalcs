namespace GeometryCalcs;

/// <summary>
///   Abstract class for adding new shape
/// </summary>
public abstract class Shape
{
  /// <summary>
  ///   Constructor for new Shape
  /// </summary>
  /// <param name="area">Calc area logic</param>
  protected Shape(double area)
  {
    Area = Math.Round(area, 3);
  }

  public double Area { get; set; }
}
