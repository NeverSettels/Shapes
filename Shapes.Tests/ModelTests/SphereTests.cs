using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes.Models;
using System;

namespace Shapes.Tests
{
  [TestClass]
  public class SphereTest
  {
    [TestMethod]
    public void Sphere_GetVolume_VolumeOfSphere()
    {
      Circle disk = new Circle(5.0);
      Sphere orb = new Sphere(disk);
      double result = orb.GetVolume();
      Assert.AreEqual(result,523.6);
    }

    [TestMethod]
    public void Sphere_GetSurface_SurfaceAreaOfSphere()
    {
      Circle disk = new Circle(5.0);
      Sphere orb = new Sphere(disk);
      double result = orb.GetSurface();
      Assert.AreEqual(result,314.16);
    }
  }
}