using System;

namespace Shapes.Models
{
 public class Circle
{
  public double Radius{ get; set;}
  public Circle(double radius)
  {
    Radius = radius;
  }

  public double GetDiameter()
  {
    return Radius *2.0;
  }
  public double GetCircumference()
  {
    return Radius*2*3.14;
  }
}
}
