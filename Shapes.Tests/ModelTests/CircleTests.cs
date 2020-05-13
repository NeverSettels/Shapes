using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes.Models;
using System;

namespace Shapes.Tests
{
  [TestClass]
  public class CircleTest
  {
    [TestMethod]
    public void Circle_GetCircumference_CircumferenceOfCircle()
    {
      Circle tester = new Circle(5.0);
      double result = tester.GetCircumference();
      Assert.AreEqual(Math.Round(result,1), Math.Round(31.4,1));
    }
  }
}