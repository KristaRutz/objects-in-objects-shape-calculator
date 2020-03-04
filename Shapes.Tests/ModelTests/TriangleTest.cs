using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes.Models;

namespace Shapes.Tests
{
  [TestClass]
  public class TriangleTests
  {
    [TestMethod]
    public void Triangle_GetArea_AreaOfTriangle()
    {
      Triangle newTriangle = new Triangle(4, 6);
      int result = newTriangle.GetArea();
      Assert.AreEqual(result, 12);
    }

  }
}