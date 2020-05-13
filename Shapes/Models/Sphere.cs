using System;

namespace Shapes.Models
{
  public class Sphere
  {
    public Circle CrossSection {get; set;}

    public Sphere(Circle circle)
    {
      CrossSection = circle;
    }

    public double GetVolume ()
    {
     return Math.Round((4.0*Math.PI*Math.Pow(CrossSection.Radius, 3.0))/3.0, 1);
    }

    public double GetSurface()
    {
      return 0; //return Math.Round(4*Math.PI* Math.Pow(CrossSection.Radius,2),2)
    }

  }

}