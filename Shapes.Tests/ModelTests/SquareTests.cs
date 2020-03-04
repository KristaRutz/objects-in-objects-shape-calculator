using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes.Models;

namespace Shapes.Tests
{
  [TestClass]
  public class SquareTests
  {
    [TestMethod]
    public void Square_GetArea_AreaOfSquare()
    {
      Square newSquare = new Square(4);
      int result = newSquare.GetArea();
      Assert.AreEqual(result, 16);
    }

    [TestMethod]

    public void Square_IsSquare_True()
    {
      Square newSquare = new Square(4);
      bool result = newSquare.IsSquare();
      Assert.AreEqual(result, true);
    }

    [TestMethod]
    public void Cube_CanBeMadeFromtSquareClass_True()
    {
      Square newSquare = new Square(4);
      Cube newCube = new Cube(newSquare);

      int result = newCube.GetSurfaceArea();
      Assert.AreEqual(96, result);
    }
  }
}